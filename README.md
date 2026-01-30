# CloudOps Task Processing Platform

A production-style **microservice-based task processing platform** designed to demonstrate real-world backend, infrastructure, and cloud operations skills using modern technologies such as **.NET 8**, **RabbitMQ**, **PostgreSQL**, **Kubernetes**, **SaltStack**, and **Linux**.

This project simulates how large-scale systems handle asynchronous workloads, service scalability, and infrastructure automation in data-centre environments.

---

## 🚀 Project Overview

The CloudOps Task Processing Platform allows clients to submit tasks via a REST API.  
Tasks are processed asynchronously using a message queue, handled by background worker services, and can be extended to persist results in a database.

The system is fully containerized, Kubernetes-ready, and includes configuration automation using SaltStack.

---

## 🧱 Architecture

Client
|
| REST API Request
v
API Service (.NET 8)
|
| Publish Task Message
v
RabbitMQ
|
| Consume Message
v
Worker Service (.NET 8)
|
| (Optional) Persist Results
v
PostgreSQL


---

## 🛠️ Technology Stack

| Category | Technologies |
|--------|-------------|
| Backend | C# .NET 8 (ASP.NET Core) |
| Messaging | RabbitMQ |
| Database | PostgreSQL |
| Containerization | Docker |
| Orchestration | Kubernetes |
| Configuration Management | SaltStack |
| Operating System | Linux |

---

## ✨ Key Features

- REST API for task submission
- Asynchronous task processing using RabbitMQ
- Background worker service for task execution
- PostgreSQL database schema for persistence
- Dockerized services for portability
- Kubernetes deployment configurations for scalability
- SaltStack state files for Linux infrastructure automation
- Clean, modular microservice architecture

---

## 📂 Project Structure



cloudops-task-platform/
│
├── api-service/ # .NET 8 REST API service
│ ├── Controllers/
│ ├── Program.cs
│ ├── Dockerfile
│
├── worker-service/ # Background task processor
│ ├── Program.cs
│ ├── Dockerfile
│
├── database/
│ └── init.sql # PostgreSQL schema
│
├── kubernetes/ # Kubernetes manifests
│ └── api-deployment.yaml
│
├── saltstack/ # SaltStack configuration
│ └── install_docker_k8s.sls
│
├── docker-compose.yml # Local development setup
├── README.md


---

## ⚙️ How It Works

1. A client sends a task request to the API service.
2. The API service publishes the task to a RabbitMQ queue.
3. The worker service consumes tasks from the queue.
4. The worker processes tasks asynchronously.
5. The system can be extended to store task results in PostgreSQL.
6. Kubernetes manages service scaling and availability.
7. SaltStack automates Linux server package installations.

---

## 🐳 Running Locally with Docker Compose

### Prerequisites
- Docker
- Docker Compose

### Start the system
```bash
docker-compose up --build

Access services

API Service: http://localhost:5000

RabbitMQ Management UI: http://localhost:15672

Username: guest

Password: guest

☸️ Kubernetes Deployment

The project includes Kubernetes manifests to deploy services in a cluster.

kubectl apply -f kubernetes/


Features:

Stateless microservices

Replica-based scaling

Container-based deployments

🧂 Infrastructure Automation with SaltStack

SaltStack state files are included to automate installation of essential infrastructure components on Linux servers:

Docker

Kubernetes dependencies

This reflects real-world data centre and infrastructure automation practices.

🔒 Production-Ready Extensions (Future Enhancements)

PostgreSQL integration in worker service

Centralized logging and monitoring

Health checks and readiness probes

Secrets management using Kubernetes Secrets

CI/CD pipeline using GitHub Actions

Horizontal Pod Autoscaling (HPA)

🎯 Why This Project?

This project was built to demonstrate:

Real-world backend engineering practices

Asynchronous system design

Cloud-native and data-centre-ready deployments

Infrastructure automation on Linux systems

Production-oriented microservice architecture

👤 Author

Sanjay V
Aspiring Backend / Cloud / Infrastructure Engineer
Tech Stack: .NET | Kubernetes | RabbitMQ | PostgreSQL | Linux

📜 License

This project is open-source and intended for educational and demonstration purposes.



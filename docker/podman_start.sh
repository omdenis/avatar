#!/bin/bash

# sudo dnf install -y podman-compose

podman-compose -f podman_compose.yaml down
podman-compose -f podman_compose.yaml up -d

podman ps -a

# Postgres Admin
xdg-open "http://127.0.0.1:5050" >/dev/null 2>&1 &

# Jaeger UI
xdg-open "http://127.0.0.1:16686" >/dev/null 2>&1 &

#!/bin/bash

# sudo dnf install -y podman-compose

podman-compose -f podman_compose.yaml up -d

podman ps -a

xdg-open "http://127.0.0.1:5050" >/dev/null 2>&1 &


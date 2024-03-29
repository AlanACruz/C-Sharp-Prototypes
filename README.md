# Copyright (C) 2021 Alan Cruz
# C-Sharp-Prototypes

# Git Clone
```
git clone git@github.com:AlanACruz/C-Sharp-Prototypes.git ~/git/C-Sharp-Prototypes
```

# Install Docker on Chromebook
https://github.com/AlanACruz/DevSecOps/blob/master/docker/Install-Docker-On-Chromebook.md

# Run Container
```
docker run \
   -v ~/.nuget:/root/.nuget/ \
   -v ~/git/C-Sharp-Prototypes:/root/git/C-Sharp-Prototypes \
   -t \
   -i \
   --rm \
   mcr.microsoft.com/dotnet/sdk:5.0
```

# Build from Container
```
cd /root/git/C-Sharp-Prototypes

dotnet build
```

# Set up for local .NET build
```
curl https://dot.net/v1/dotnet-install.sh --output ~/Downloads/dotnet-install.sh

cd ~/Downloads/

./dotnet-install.sh -c Current
```

# Run .NET build locally
```
cd ~/git/C-Sharp-Prototypes

dotnet build
```

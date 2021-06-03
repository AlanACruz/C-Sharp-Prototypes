# Copyright (C) 2021 Alan Cruz
# C-Sharp-Prototypes

# git clone
```
git clone git@github.com:AlanACruz/C-Sharp-Prototypes.git ~/git/
```

# install docker
```
sudo apt update

sudo apt install -y \
   apt-transport-https \
   ca-certificates \
   curl \
   gnupg2 \
   software-properties-common

curl -fsSL https://download.docker.com/linux/debian/gpg | sudo apt-key add -

sudo add-apt-repository \
   "deb [arch=amd64] https://download.docker.com/linux/debian \
   $(lsb_release -cs) \
   stable"
   
sudo apt update

sudo apt install -y \
   docker-ce \
   docker-ce-cli \
   containerd.io
```

# Enable non-root docker (Chromebook)
```
sudo usermod -aG docker $USER

sudo chmod 666 /var/run/docker.sock
```

# Pull .NET container
```
docker pull mcr.microsoft.com/dotnet/sdk:5.0
```

# Run .NET build from container
```
docker run \
   -v ~/.nuget:/root/.nuget/ \
   -v ~/git/C-Sharp-Prototypes:/root/git/C-Sharp-Prototypes \
   -t \
   -i \
   --rm \
   mcr.microsoft.com/dotnet/sdk:5.0

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

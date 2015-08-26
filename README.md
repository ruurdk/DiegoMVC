# DiegoMVC
A minimal MVC project for testing Cloud Foundry Diego deployments

## Prerequisites

To push this app, you need to [download the diego plugin](https://github.com/cloudfoundry-incubator/diego-cli-plugin) and deploy to [an environment with .NET support](http://docs.pivotal.io/pivotalcf/opsguide/deploying-diego.html)

## Preparation

##### Build from source
Clone this repo.
Open in Visual Studio, and publish using the Pivotal profile.

##### Using the binaries
[Download the zip](https://github.com/ruurdk/DiegoMVC/raw/master/DiegoMVC_Compiled.zip) and extract it.

## Deploy
```
cf push diegoMVC -m 1g -s windows2012R2 -b https://github.com/ryandotsmith/null-buildpack.git --no-start -p ./
cf enable-diego diegoMVC
cf start diegoMVC
```

#!/bin/bash

# get path to script
SCRIPT_PATH="$( cd "$(dirname "$0")" ; pwd -P )"

# get one level up from script path
PROJECT_PATH=$(dirname "$SCRIPT_PATH")


if [ ! -f ~/bin/openapitools/openapi-generator-cli ] || [ "$1" == "-f" ]; then
    mkdir -p ~/bin/openapitools
    curl https://raw.githubusercontent.com/OpenAPITools/openapi-generator/master/bin/utils/openapi-generator-cli.sh > ~/bin/openapitools/openapi-generator-cli
    chmod u+x ~/bin/openapitools/openapi-generator-cli
    export PATH=$PATH:~/bin/openapitools/
else
    echo "openapi-generator-cli exists, skip installation"
fi



# Execute latest released openapi-generator-cli
openapi-generator-cli version

# To "install" a specific version, set the variable in .bashrc/.bash_profile
curl https://developer.servicechannel.com/api/docs?name=ServiceAutomation > $SCRIPT_PATH/serviceChannelSwagger.json
openapi-generator-cli generate \
    -i $SCRIPT_PATH/serviceChannelSwagger.json \
    -g csharp-netcore \
    -o $PROJECT_PATH \
    -c $SCRIPT_PATH/config.json \
    --skip-validate-spec \
    --remove-operation-id-prefix \
    --model-name-prefix SC



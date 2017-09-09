#!/usr/bin/env bash
#
# Generated by: https://github.com/swagger-api/swagger-codegen.git
#

frameworkVersion=net46
netfx=${frameworkVersion#net}

echo "[INFO] Target framework: ${frameworkVersion}"

echo "[INFO] Download nuget and packages"
wget -nc https://nuget.org/nuget.exe;
mozroots --import --sync
mono nuget.exe install src/Ee.Rockit.LuisClient/packages.config -o packages;

echo "[INFO] Copy DLLs to the 'bin' folder"
mkdir -p bin;
cp packages/Newtonsoft.Json.10.0.3/lib/net45/Newtonsoft.Json.dll bin/Newtonsoft.Json.dll;
cp packages/RestSharp.105.2.3/lib/net45/RestSharp.dll bin/RestSharp.dll;

echo "[INFO] Run 'mcs' to build bin/Ee.Rockit.LuisClient.dll"
mcs -sdk:${netfx} -r:bin/Newtonsoft.Json.dll,\
bin/RestSharp.dll,\
System.ComponentModel.DataAnnotations.dll,\
System.Runtime.Serialization.dll \
-target:library \
-out:bin/Ee.Rockit.LuisClient.dll \
-recurse:'src/Ee.Rockit.LuisClient/*.cs' \
-doc:bin/Ee.Rockit.LuisClient.xml \
-platform:anycpu

if [ $? -ne 0 ]
then
  echo "[ERROR] Compilation failed with exit code $?"
  exit 1
else
  echo "[INFO] bin/Ee.Rockit.LuisClient.dll was created successfully"
fi
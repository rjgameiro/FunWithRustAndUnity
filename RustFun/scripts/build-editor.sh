#!/bin/bash

UNITY_PLUGINS_EDITOR="../UnityFun/Assets/Plugins/Editor"

[ "$1" == "" ] && echo "$(basename $0): please provide a package name." && exit 1

pushd `dirname $0` > /dev/null
script_path=`pwd -P`
popd > /dev/null

cd ${script_path}/..

host_triplet="$(rustc -vV | sed -n 's|host: ||p')"
cargo build --target ${host_triplet} --package $1
if [ $? -eq 0 ]; then
  mkdir -p ${UNITY_PLUGINS_EDITOR}
  rsync -v target/${host_triplet}/debug/lib$1.dylib ${UNITY_PLUGINS_EDITOR}/
fi

cd - 1> /dev/null

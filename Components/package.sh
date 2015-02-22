#!/bin/sh

VERSION=$1
if [ -z "$VERSION" ]; then
    echo "Must specify version."
    exit 1
fi

zip LiveSplit.MassEffect_v${VERSION}.zip LiveSplit.MassEffect.dll ../readme.txt

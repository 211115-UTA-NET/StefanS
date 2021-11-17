#!/usr/bin/bash

echo "File creator initiated"
echo "Enter the name of created file"

read newFile

touch $newFile

git add $newFile

git commit -m "$newFile created with tool"

git push

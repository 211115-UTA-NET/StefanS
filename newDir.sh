#!/usr/bin/bash
#C:\Users\schwe\Revature\StefanS\newDir.sh

echo "Directory creator initiated"
echo "Enter the name of the folder to be created"

read folderName                                    #input for folder name

mkdir $folderName                                 #creates folder with input

touch ./$folderName/README.md                      #creates README file in folder

echo "default text" > ./$folderName/README.md      #first line in README

for i in {1..20..2}                                #runs odd numbers 1-20
do
  nums+=$i
  if(( $i <= 18 ))                                  #loop condition
    then
      nums+=", "                                  #adds numbers to nums stirng
    fi
  done

  echo $nums >> ./$folderName/README.md

  echo "$folderName has been created"

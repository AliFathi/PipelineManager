#!/bin/bash

URL="http://{Site-Address}/iis/sites/appoffline/add/"

# store the whole response with the status at the and
HTTP_RESPONSE=$(curl --silent --write-out "HTTPSTATUS:%{http_code}" -X GET $URL)

# extract the body
HTTP_BODY=$(echo $HTTP_RESPONSE | sed -e 's/HTTPSTATUS\:.*//g')

# extract the status
HTTP_STATUS=$(echo $HTTP_RESPONSE | tr -d '\n' | sed -e 's/.*HTTPSTATUS://')

if [ ! $HTTP_STATUS -eq 200  ]; then
  echo "##[error]$HTTP_BODY"
  exit 1
fi

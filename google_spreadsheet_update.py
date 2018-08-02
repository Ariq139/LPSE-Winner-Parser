#!/usr/bin/python3.7
from __future__ import print_function
from apiclient.discovery import build
from httplib2 import Http
from oauth2client import file, client, tools
import sys

def updateGSheet(num, name, type, instance, winner, id, loc_):
    # Setup the Sheets API
    SCOPES = 'https://www.googleapis.com/auth/spreadsheets'
    store = file.Storage('credentials.json')
    creds = store.get()
    if not creds or creds.invalid:
        flow = client.flow_from_clientsecrets('client_secret.json', SCOPES)
        creds = tools.run_flow(flow, store)
    service = build('sheets', 'v4', http=creds.authorize(Http()))

    # The ID of the spreadsheet to update.
    spreadsheet_id = '1_UGhpuvRkD4dQ1xn1jgQ-5pflQ6RHKYYsLq2LEOlSzU'

    # The A1 notation of the values to update.
    range_ = loc_+'!A'+str(num+1)

    # How the input data should be interpreted.
    value_input_option = 'RAW'

    value_range_body = {
        "majorDimension": "COLUMNS",
        "range": range_,
        "values": [
            [
                id
            ],
            [
                name
            ],
            [
                type
            ],
            [
                instance
            ],
            [
                winner
            ]
        ]
    }

    request = service.spreadsheets().values().update(spreadsheetId=spreadsheet_id, range=range_, valueInputOption=value_input_option, body=value_range_body)
    response = request.execute()
    
if __name__ == "__main__":
    num = int(sys.argv[1])
    name = str(sys.argv[2])
    type = str(sys.argv[3])
    instance = str(sys.argv[4])
    winner = str(sys.argv[5])
    id = str(sys.argv[6])
    loc_ = str(sys.argv[7])

    updateGSheet(num, name, type, instance, winner, id, loc_)
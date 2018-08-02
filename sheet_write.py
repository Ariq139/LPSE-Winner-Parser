#!/usr/bin/python3.7
import tablib, sys

def writeFile(file, type, id):
    dataTab = tablib.Dataset()
    dataTab.xlsx = open(file+'.xlsx', 'rb').read()
    
    dataTab.append([type, id, "", "", "", "", "", id, "", "", "", "", "", ""])

    with open(file+'.xlsx', 'wb') as f:
        f.write(dataTab.xlsx)
    #print(dataTab[1:4])
    
if __name__ == "__main__":
    file = str(sys.argv[1])
    type = str(sys.argv[2])
    id = str(sys.argv[3])
    
    writeFile(file, type, id)
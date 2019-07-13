import datetime
import sqlite3
import time
import random

conn = sqlite3.connect('EpicCharactersDictionary.db')
c = conn.cursor()

def CreateData():
    c.execute("CREATE TABLE StoryData(storyId INTEGER PRIMARY KEY, storyTitle text, storyGenre text, storyBio text)")
    c.execute("CREATE TABLE CharacterData(characterId INTEGER PRIMARY KEY, firstName text, lastName text, age integer, gender char)")

def InsertData():
    c.execute("INSERT INTO StoryData VALUES(001, 'Super Smash Bros. 3D - World of Realities', 'Action/Adventure', 'Based on Smash Bros. for 3DS and Wii U, tells the story of gamer Jace and his best friend Hunt...')")
    c.execute("INSERT INTO StoryData VALUES(002, 'Super Smash Bros. HD - World of Light', 'Action/Adventure', 'Based on Smash Bros. Ultimate - World of Light, tells the story of Jace and Hunt, from an alternate Earth...')")
    c.execute("INSERT INTO CharacterData VALUES(01, 'Jacen', 'Riders', 19, 'M')")
    c.execute("INSERT INTO CharacterData VALUES(02, 'Hunter', 'Long', 19, 'M')")
    c.execute("INSERT INTO CharacterData VALUES(03, 'Jennifer', 'Dimentio', 19, 'F')")
    c.execute("INSERT INTO CharacterData VALUES(04, 'Patricia', 'Turner', 17, 'F')")
    c.execute("INSERT INTO CharacterData VALUES(05, 'Maple', 'Reid', 14, 'F')")
    c.execute("INSERT INTO CharacterData VALUES(06, 'Christian', 'Chevalier', 25, 'M')")
    c.execute("INSERT INTO CharacterData VALUES(07, 'Serena', 'L''eclair', 13, 'F')")
    c.execute("INSERT INTO CharacterData VALUES(08, 'Noir', 'DeRoi', 23, 'M')")
    c.execute("INSERT INTO CharacterData VALUES(09, 'Cassie', 'DeBellefort', 19, 'F')")

def TestData():
    c.execute("SELECT * FROM StoryData WHERE storyTitle LIKE '%Smash%'")    # make a select clause for stories containing certain words
    print(c.fetchall())
    c.execute("SELECT * FROM CharacterData WHERE gender='F'")               # select for certain character with certain criteria. Here we're looking for gender
    print(c.fetchall())


def main():
    #CreateData()
    #InsertData()
    TestData()
    conn.commit()
    conn.close()

if __name__ == "__main__":
    main()
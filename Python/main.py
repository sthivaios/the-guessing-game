import random

#var initiation
nextround = True
score = 0
rounds = 0

print()
print()
print("KIOYDIOLABS © 2023")
print()
print(" __          __  _                          _ ")
print(" \ \        / / | |                        | |")
print("  \ \  /\  / /__| | ___ ___  _ __ ___   ___| |")
print("   \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \ |")
print("    \  /\  /  __/ | (_| (_) | | | | | |  __/_|")
print("     \/  \/ \___|_|\___\___/|_| |_| |_|\___(_)")
print("")
print("")
print("Welcome to the 'Guessing Game'")

while (nextround == True):
    rounds = rounds + 1
    rand = random.choice([0,1,2,3,4,5,6])
    print("A random number, between 0-6 has been selected.")
    print("What do you think the correct number is?")
    userinput = input("Enter a number between 0-6 > ")
    if (int(userinput) == int(rand)) :
        print("You are correct! The number is " + str(rand))
        score = score + 1
        print()
        print()
        print("Score : " + str(score))
    elif userinput == "" :
        print("You must enter an number")
    elif int(userinput) > 6 or int(userinput) < 0 :
        print("You cannot enter a number above 6 or below 0.")
    else :
        print("You are wrong! The correct number was " + str(rand))
        print("Score : " + str(score))
    print()
    print()
    print()
    nextround = input("You you want to go for another round? [y/n]")
    if (nextround == "y") :
        nextround = True
    else :
        nextround = False
    if (nextround == False) :

        print()
        print()
        print("Your final score is " + str(score) +  ".")
        print("You played " + str(rounds) + " rounds.")
        print("  ____                   _                     __  ")
        print(" |  _ \                 | |        _           \ \ ")
        print(" | |_) |  _   _    ___  | |       (_)  ______   | |")
        print(" |  _ <  | | | |  / _ \ | |           |______|  | |")
        print(" | |_) | | |_| | |  __/ |_|        _            | |")
        print(" |____/   \__, |  \___| (_)       (_)           | |")
        print("           __/ |                               /_/ ")
        print("          |___/                                    ")
        print()
        print()
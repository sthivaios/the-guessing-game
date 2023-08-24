echo ""
echo ""
echo "KIOYDIOLABS © 2023"
echo ""
echo " __          __  _                          _ "
echo " \ \        / / | |                        | |"
echo "  \ \  /\  / /__| | ___ ___  _ __ ___   ___| |"
echo "   \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \ |"
echo "    \  /\  /  __/ | (_| (_) | | | | | |  __/_|"
echo "     \/  \/ \___|_|\___\___/|_| |_| |_|\___(_)"
echo ""
echo ""
echo "Welcome to the 'Guessing Game'"
echo ""
echo ""

$rounds=0
$score=0
$nextround="y"
while ($nextround -eq "y"){
    $rounds=$rounds+1
    $rand=Get-Random -Minimum 0 -Maximum 6
    $userinput = Read-Host "Please enter a number between 0 and 6 "
    if ($userinput -eq $rand){
        echo ""
        echo "You are correct! The number was indeed $rand"
        echo ""
        $score=$score+1
        echo "----------------"
        echo "|   Score : $score  |"
        echo "----------------"
        echo "|   Round : $rounds  |"
        echo "----------------"
        echo ""
        $nextround = Read-Host "Try again? [y/n]"
        echo ""
    }
    else{
        
        echo ""
        echo "You are wrong! The number was $rand"
        echo ""
        echo "----------------"
        echo "|   Score : $score  |"
        echo "----------------"
        echo "|   Round : $rounds  |"
        echo "----------------"
        echo ""
        $nextround = Read-Host "Try again? [y/n]"
        echo ""
    }
}

echo ""
echo ""
echo "Your final score is $score."
echo "You played $rounds rounds."
echo ""
echo " ____                   _                     __  "
echo "|  _ \                 | |        _           \ \ "
echo "| |_) |  _   _    ___  | |       (_)  ______   | |"
echo "|  _ <  | | | |  / _ \ | |           |______|  | |"
echo "| |_) | | |_| | |  __/ |_|        _            | |"
echo "|____/   \__, |  \___| (_)       (_)           | |"
echo "          __/ |                               /_/ "
echo "         |___/                                    "
echo ""
echo ""
echo "KIOYDIOLABS © 2023"
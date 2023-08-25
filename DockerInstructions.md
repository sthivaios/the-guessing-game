Instructions for installing on Docker

1. Install Docker on your server
It will probably be an Ubuntu Linux server
so for that you can use the command : apt install docker.io -y

2. Pull and run the image
To run the image on your Docker server, use the following command :
"docker run --name GuessingGame -d -p 80:80 sthivaios/the-guessing-game:latest"

The "--name" part will give the "GuessingGame" name to the container.
The "-d" part will run the container as a daemon so the output doesn't take
up the shell, and it essentially runs in the background.
The "-p 80:80" will forward the port 80 of the container to the port 80
of the Docker server. If you wish to change the port that the GuessingGame is hosted
on the server, change the port number that is before the ":". DO NOT change the port
after the ":" as that is the port that the httpd server of the image is hosting the webpage.
Finally, the "sthivaios/the-guessing-game:latest" (of course) sets the image to pull and run
and the ":latest" specifies the version, which in this case obviously downloads the latest image.

(If you do want to install it and you need more help than this you can send an email
at helpdesk@kioydio.org)
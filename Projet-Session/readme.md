Projet de session
=================

Ce dossier contient trois projets VS. Il y a le Client, le Serveur et la librairie SharedObject qui est partagé entre les deux autres.

Remarque
--------

 - Il faut s'assurer de compiler le serveur avec la bonne architecture afin qu'il puisse ouvrir la base de données (x64 par défaut)
 - Il faut construire SharedObject avant les autres.
 - Il est préférable de s'assure que les projets Client et Serveur partage la même version de SharedObject.
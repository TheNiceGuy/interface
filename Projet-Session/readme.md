Projet de session
=================

Ce dossier contient trois projets VS. Il y a le Client, le Serveur et la librairie SharedObject qui est partag� entre les deux autres.

Remarque
--------

 - Il faut s'assurer de compiler le serveur avec la bonne architecture afin qu'il puisse ouvrir la base de donn�es (x64 par d�faut)
 - Il faut construire SharedObject avant les autres.
 - Il est pr�f�rable de s'assure que les projets Client et Serveur partage la m�me version de SharedObject.
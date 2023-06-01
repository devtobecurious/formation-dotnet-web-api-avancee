# HTTP
## Versions
### Version 1
HTTP 1.0 : meta donn�es. HTTP 1.1. le standard (pipeline, morceaux)
### Version 2
HTTP 1.1 n�cessite ordre s�quentiel. pipeline fardeau. SPDY (google) : base http/2.  
Encod� en binaire (au lieu de texte). Multiplex� : plusieurs requ�tes au sein m�me requ�te. 
Compression ent�tes.  
2015 valid�.
### Version 3
Protocol QUIC (google) initialise l'id�e (2012).  HTTP1.1 et HTTP/2 s'appuie sur la couche Transport.  
HTTP/3 s'appuie sur QUIC => corriger Head of line Blocking.  
Tous les flux sont ind�pendants (encapsul�s dans UDP).  
QUIC : TCP/2. 2023 : prise en charge par quasi tous les navigateurs.  
  
Support� par asp.net core 7 et +
## Methods
### GET 
La m�thode GET demande une repr�sentation de la ressource sp�cifi�e. Les requ�tes GET doivent uniquement �tre utilis�es afin de r�cup�rer des donn�es.
### POST
La m�thode POST est utilis�e pour envoyer une entit� vers la ressource indiqu�e. Cela entra�ne g�n�ralement un changement d'�tat ou des effets de bord sur le serveur.
### PUT
La m�thode PUT remplace toutes les repr�sentations actuelles de la ressource vis�e par le contenu de la requ�te.
### PATCH
La m�thode PATCH est utilis�e pour appliquer des modifications partielles � une ressource.
### DELETE
La m�thode DELETE supprime la ressource indiqu�e.
### OPTIONS
La m�thode HTTP OPTIONS est utilis�e pour d�crire les options de communication pour la ressource cibl�e. Le client peut renseigner une URL sp�cifique pour la m�thode OPTIONS, ou une ast�risque (*) pour interroger le serveur dans sa globalit�.

# REST FULL
Representational state transfer 
## Stateless
## HATEOAS
Hypermedia As The Engine of Application State


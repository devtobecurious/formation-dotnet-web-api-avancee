# HTTP
## Versions
### Version 1
HTTP 1.0 : meta données. HTTP 1.1. le standard (pipeline, morceaux)
### Version 2
HTTP 1.1 nécessite ordre séquentiel. pipeline fardeau. SPDY (google) : base http/2.  
Encodé en binaire (au lieu de texte). Multiplexé : plusieurs requêtes au sein même requête. 
Compression entêtes.  
2015 validé.
### Version 3
Protocol QUIC (google) initialise l'idée (2012).  HTTP1.1 et HTTP/2 s'appuie sur la couche Transport.  
HTTP/3 s'appuie sur QUIC => corriger Head of line Blocking.  
Tous les flux sont indépendants (encapsulés dans UDP).  
QUIC : TCP/2. 2023 : prise en charge par quasi tous les navigateurs.  
  
Supporté par asp.net core 7 et +
## Methods
### GET 
La méthode GET demande une représentation de la ressource spécifiée. Les requêtes GET doivent uniquement être utilisées afin de récupérer des données.
### POST
La méthode POST est utilisée pour envoyer une entité vers la ressource indiquée. Cela entraîne généralement un changement d'état ou des effets de bord sur le serveur.
### PUT
La méthode PUT remplace toutes les représentations actuelles de la ressource visée par le contenu de la requête.
### PATCH
La méthode PATCH est utilisée pour appliquer des modifications partielles à une ressource.
### DELETE
La méthode DELETE supprime la ressource indiquée.
### OPTIONS
La méthode HTTP OPTIONS est utilisée pour décrire les options de communication pour la ressource ciblée. Le client peut renseigner une URL spécifique pour la méthode OPTIONS, ou une astérisque (*) pour interroger le serveur dans sa globalité.

# REST FULL
Representational state transfer 
## Stateless
## HATEOAS
Hypermedia As The Engine of Application State


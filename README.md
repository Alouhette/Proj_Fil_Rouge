# Proj_Fil_Rouge

## Objectif: 
***-Réaliser un projet de météo**
##

**Étape à suivre:**

***Les étapes seront évolutif, en fonction de l'evolution du Cours***

## 1er Étape: ##

***Modélisation du monde Météorologique***

Nous avons choisi un monde simple, composé d'un sol, d'un arbre qui sera indicateur du changement de la météo en fonction des variations de la temperature à travers l'appel d'une API, puis d'un personna(le testeur portant le casque ou le simulateur du monde) qui subira les changements de temperature et de saison.

## 2nd Étape: ##

**Organisation de la scène**
Nous avons choisis la scène principal(Basic URP) se nommant **SampleScene**.

*Sol:* 
Nous avons décomposé le sol en 2 parties deux sol, contenu dans le l'objet **Ground** se nommant **Dirt** et **Dirt 2**

*Arbre:*
Nous avons aussi choisis, un arbre qui nous indiquera le changement de saison, et les variations de nature externe, qu'ils fassent: pluvieux, neigé, ensolleillé... Illustré par l'objet **Tree** composé :

* D'un tronc se trouvant dans le l'objet ***Wood***
* Des branches illustré dans l'objet **Sunny Leaves** composé de:
* ***Leafs 1***
* ***Leafs 2-1***
* ***Leafs 2-2***
* ***Leafs 3***

(Il possède notamment plusieur  en fonction de la météo)

*Pickaxe & Blocks:*
Il s'agis d'objet/Prefab pour testers les intéractions avec la VR, la pickaxe sert à frapper les blocs pour tester leurs physique.

**Organisation des Assets:**

Nos dossiers sont organisés de la façon suivante :
* ***Materials*** (pour stockers les matériaux et couleurs de nos objets)
* ***Prefabs*** (pour stockers les Prefabs de nos objets que l'on adapte au besoin)
* ***Scenes*** (pour stocker nos scènes, il n'y en à qu'une pr le moment)
* ***Scripts*** (Bientot pour stocker les scripts relié à nos objets et prefabs)

## 3eme Étape: ##

**Fonctionnalitées**

*Déplacement:*
Joystick gauche : Pour le déplacement
Joystick droit : Pour tourner la Caméra

*Intéractions:*
Possibilité d'attraper une "pickaxe", de la lancer ou encore de l'utiliser pour taper dans les blocks

*Retours:*
(To be done)



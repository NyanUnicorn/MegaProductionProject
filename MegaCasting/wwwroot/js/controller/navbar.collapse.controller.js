/**
*Contrôleur pour l'effondrement du menu
* @param {string} [nom contrôleur] @param {function} [enssemble de fonction prennant effet dans [$scope]]
*/
app.controller('menuCollapse', function($scope){
  var toggle = "untoggled";
  var select = " selected";
  var a = document.getElementById("arrow0");
  var b = document.getElementById("list0");

  /**
   * Vérifier l'état de [toggle] et modifier sa valeur en fonction de celle qu'elle a déjà avec son inverse.
   */
  $scope.toggleMenu = function(){
    if(toggle === "untoggled"){
      toggle = "toggled";
    }else{
      toggle = "untoggled";
    }

    refreshToggle();
  }
  /**
   * Modifie l'état de [toggle] en chaine "untoggle"
   */
  $scope.untoggleMenu = function(){
    toggle = "untoggled";
    refreshToggle();

  }
  /**
   * Modifie la classe sur les elements avec les id A et b en ajoutant la chaine de la variable [toggle]
   */
  function refreshToggle(){
    a.classList = "arrowBlock " + toggle;
    b.classList = "list " + toggle;
    menu.classList = toggle;

  }
});

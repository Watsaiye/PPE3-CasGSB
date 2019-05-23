<?php

include 'cnx.php';
$sql = $cnx->prepare("INSERT INTO `type_individu`(`MED_DEPOTLEGAL`, `MED_NOMCOMMERCIAL`, `FAM_CODE`, `MED_COMPOSITION`, `MED_EFFETS`, `MED_CONTREINDIC`, `MED_PRIXECHANTILLON`) VALUES ('" + $_GET['depot'] + "', '" + $_GET['nomcom'] + "', '" + $_GET['codefam'] + "', '" + $_GET['compo'] + "', '" + $_GET['effets'] + "', '" + $_GET['contreindic'] + "', '" + $_GET['prix'] + "'");

$sql->execute();

?>  
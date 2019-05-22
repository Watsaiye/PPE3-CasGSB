<?php

include 'cnx.php';
$sql = $cnx->prepare("UPDATE `medicament` SET `MED_DEPOTLEGAL`= " + $_GET['depot'] + ", `MED_NOMCOMMERCIAL` = '" + $GET_['nom'] + ", `FAM_CODE` = '" + $GET_['code'] + ", `MED_COMPOSITION` = '" + $GET_['compo'] + ", `MED_EFFETS` = '" + $GET_['effets'] + ", `MED_CONTREINDIC` = '" + $GET_['contreindic'] + ", `MED_PRIXECHANTILLON` = '" + $GET_['prix'] + "' WHERE 1");
$sql->execute();
?>  
<?php

include 'cnx.php';
$sql = $cnx->prepare("UPDATE `type_individu` SET `TIN_CODE`= " + $_GET['code'] + ", `TIN_LIBELLE` = '" + $GET_['libelle'] + "' WHERE `TIN_CODE` = " + $_GET['code'] + "'");
$sql->execute();
?>  
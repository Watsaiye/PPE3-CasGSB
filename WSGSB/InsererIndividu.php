<?php

include 'cnx.php';
$sql = $cnx->prepare("INSERT INTO `type_individu`(`TIN_CODE`, `TIN_LIBELLE`) VALUES ('" + $_GET['code'] + "', '" + $_GET['libelle'] + "'");
$sql->execute();

?>  
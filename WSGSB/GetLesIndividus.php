<?php

include 'cnx.php';
$sql = $cnx->prepare("select TIN_CODE as Code, TIN_LIBELLE as Lib from TYPE_INDIVIDU");
$sql->execute();

$data = $sql->fetchAll(PDO::FETCH_ASSOC);
echo json_encode($data);

?>  
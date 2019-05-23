<?php

include 'cnx.php';
$sql = $cnx->prepare("select MED_DEPOTLEGAL as Depot, MED_NOMCOMMERCIAL as NomCom, FAM_CODE as CodeFam, MED_COMPOSITION as Compo, MED_EFFETS as Effets, MED_CONTREINDIC as Contreindic, MED_PRIXECHANTILLON as Prix from medicament");
$sql->execute();

$data = $sql->fetchAll(PDO::FETCH_ASSOC);
echo json_encode($data);

?>
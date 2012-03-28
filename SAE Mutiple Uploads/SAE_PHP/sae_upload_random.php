<?php
/**
 * KindEditor PHP
 * 
 * 本PHP程序是演示程序，建议不要直接在实际项目中使用。
 * 如果您确定直接使用本程序，使用之前请仔细确认相关安全设置。
 * 
 * from http://download.csdn.net/download/bhzln/3532744
 * 
 * 此文件用于SAE Storage的批量上传
 * by http://www.shootsoft.net
 */


//文件保存目录路径
$domain = $_GET["namespace"];
$dest = $_GET["dest"];
//最大文件大小 10MB
$max_size = 10*1024*1024;
//有上传文件时
if (empty($_FILES) === false) {
	//原文件名
	$file_name = $_FILES['file']['name'];
	//服务器上临时文件名
	$tmp_name = $_FILES['file']['tmp_name'];
	//文件大小
	$file_size = $_FILES['file']['size'];
	//检查文件名
	if (!$file_name) {
		alert("请选择文件。");
	}
	//检查是否已上传
	if (@is_uploaded_file($tmp_name) === false) {
		alert("临时文件可能不是上传文件。");
	}
	//检查文件大小
	if ($file_size > $max_size) {
		alert("上传文件大小超过限制。");
	}	
	//新文件名
	$new_file_name = $dest;
    	//上传文件并返回地址
	$s = new SaeStorage();
    	$file_url = $s->upload( $domain , $new_file_name , $tmp_name);
	alert($file_url);
} else {
	alert('null');
}

function alert($msg) {
	header('Content-type: text/html; charset=UTF-8');
	echo $msg;
	exit;
}
?>
﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sjzymleft.aspx.cs" Inherits="sjzymleft" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <title>商家管理系统</title>
         <link href="css/sjzymleft.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    
    <div class="container">

	<div class="leftsidebar_box">
		<div class="line"></div>
		<dl class="system_log">
			<dt onClick="changeImage()">系统记录<img src="image/sj/left/select_xl01.png"></dt>
			<dd class="first_dd"><a href="#">充值记录</a></dd>
			<dd><a href="#">短信充值记录</a></dd>
			<dd><a href="#">消费记录</a></dd>
			<dd><a href="#">操作记录</a></dd>
		</dl>
	
		<dl class="custom">
			<dt onClick="changeImage()">客户管理<img src="image/sj/left/select_xl01.png"></dt>
			<dd class="first_dd"><a href="#">客户管理</a></dd>
			<dd><a href="#">试用/成交客户管理</a></dd>
			<dd><a href="#">未成交客户管理</a></dd>
			<dd><a href="#">即将到期客户管理</a></dd>
		</dl>
	
		<dl class="channel">
			<dt>渠道管理<img src="image/sj/left/select_xl01.png"></dt>
			<dd class="first_dd"><a href="#">渠道主页</a></dd>
			<dd><a href="#">渠道标准管理</a></dd>
			<dd><a href="#">系统通知</a></dd>
			<dd><a href="#">渠道商管理</a></dd>
			<dd><a href="#">渠道商链接</a></dd>
		</dl>
	
		<dl class="app">
			<dt onClick="changeImage()">APP管理<img src="image/sj/left/select_xl01.png"></dt>
			<dd class="first_dd"><a href="#">App运营商管理</a></dd>
			<dd><a href="#">开放接口管理</a></dd>
			<dd><a href="#">接口类型管理</a></dd>
		</dl>
	
		<dl class="cloud">
			<dt>大数据云平台<img src="image/sj/left/select_xl01.png"></dt>
			<dd class="first_dd"><a href="#">平台运营商管理</a></dd>
		</dl>
	
		<dl class="syetem_management">
			<dt>系统管理<img src="image/sj/left/select_xl01.png"></dt>
			<dd class="first_dd"><a href="#">后台用户管理</a></dd>
			<dd><a href="#">角色管理</a></dd>
			<dd><a href="#">客户类型管理</a></dd>
			<dd><a href="#">栏目管理</a></dd>
			<dd><a href="#">微官网模板组管理</a></dd>
			<dd><a href="#">商城模板管理</a></dd>
			<dd><a href="#">微功能管理</a></dd>
			<dd><a href="#">修改用户密码</a></dd>
		</dl>
	
		<dl class="source">
			<dt>素材库管理<img src="image/sj/left/select_xl01.png"></dt>
			<dd class="first_dd"><a href="#">图片库</a></dd>
			<dd><a href="#">链接库</a></dd>
			<dd><a href="#">推广管理</a></dd>
		</dl>
	
		<dl class="statistics">
			<dt>统计分析<img src="image/sj/left/select_xl01.png"></dt>
			<dd class="first_dd"><a href="#">客户统计</a></dd>
		</dl>
	
	</div>

</div>
    <script type="text/javascript" src="js/jquery.js"></script>
<script type="text/javascript">
    $(".leftsidebar_box dt").css({ "background-color": "#3992d0" });
    $(".leftsidebar_box dt img").attr("src", "image/sj/left/select_xl01.png");
    $(function () {
        $(".leftsidebar_box dd").hide();
        $(".leftsidebar_box dt").click(function () {
            $(".leftsidebar_box dt").css({ "background-color": "#3992d0" })
            $(this).css({ "background-color": "#317eb4" });
            $(this).parent().find('dd').removeClass("menu_chioce");
            $(".leftsidebar_box dt img").attr("src", "image/sj/left/select_xl01.png");
            $(this).parent().find('img').attr("src", "image/sj/left/select_xl.png");
            $(".menu_chioce").slideUp();
            $(this).parent().find('dd').slideToggle();
            $(this).parent().find('dd').addClass("menu_chioce");
        });
    })
</script>
    </form>
</body>
</html>

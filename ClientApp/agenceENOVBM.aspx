<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="agenceENOVBM.aspx.cs" Inherits="ClientApp.agenceENOVBM" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">

<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<link href="https://fonts.googleapis.com/css?family=Montserrat:400,700,200" rel="stylesheet" />
<link href="https://use.fontawesome.com/releases/v5.0.6/css/all.css" rel="stylesheet">
<link href="css/main4.css" rel="stylesheet" />
    <!--   Core JS Files   -->
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>

    <!------ Include the above in your HEAD tag ---------->

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>

<body class="login-page sidebar-collapse">

  <div class="page-header clear-filter" filter-color="orange">
    <div class="page-header-image" style="background-image:url('https://tra.img.pmdstatic.net/fit/http.3A.2F.2Fprd2-bone-image.2Es3-website-eu-west-1.2Eamazonaws.2Ecom.2FBIN.2F2020.2F03.2F04.2F0a8a0396-b5a3-4a50-b88f-aa394682b8c6.2Ejpeg/1200x630/quality/80/une-agence-touristique-romaine-propose-un-instagram-boyfriend-tour-a-600e.jpg')"></div>
    <div class="content">
      <div class="container">
        <div class="col-md-4 ml-auto mr-auto">
          <div class="card card-login card-plain">
            
              <!------ FORM ---------->

              <form class="form" ID="authentification" runat="server">
              
                  <div class="card-header text-center">
                <div class="logo-container">
                  <img src="https://raw.githack.com/creativetimofficial/now-ui-kit/master/assets/img/now-logo.png" alt="">
                </div>
              </div>
              <div class="card-body">
                <div class="input-group no-border input-lg">
                  <div class="input-group-prepend">
                    <span class="input-group-text">
                      <i class="now-ui-icons users_circle-08"></i>
                    </span>
                  </div>
                  <input type="text" ID="username" runat="server" class="form-control" placeholder="Nom de l'agence...">
                </div>
                <div class="input-group no-border input-lg">
                  <div class="input-group-prepend">
                    <span class="input-group-text">
                      <i class="now-ui-icons text_caps-small"></i>
                    </span>
                  </div>
                  <input type="password" ID="password" runat="server" placeholder="Mot de passe..." class="form-control" />
                </div>
              </div>
              <div class="card-footer text-center">
                <button class="btn btn-primary btn-round btn-lg btn-block" type="button" onserverclick="btnLoginAgence_Click" runat="server">Se connecter</button>
                                  
                 <button class="btn btn-primary btn-round btn-lg btn-block" type="button" onserverclick="btnLoginInvite_Click" runat="server">Invité</button>
                </div>
            </form>
                            <!------ END FORM ---------->
              
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
  
</body>


</html>

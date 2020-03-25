<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reserverChambre.aspx.cs" Inherits="ClientApp.reserverChambre" %>

<!DOCTYPE html>
<link href="//netdna.bootstrapcdn.com/bootstrap/3.1.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//netdna.bootstrapcdn.com/bootstrap/3.1.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
<link href="css/main3.css" rel="stylesheet" />
<script src="js/main2.js"></script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>


<!------ Include the above in your HEAD tag ---------->

<div class="container" runat="server">
<div class="stepwizard">
    <div class="stepwizard-row setup-panel" runat="server">
        <div class="stepwizard-step">
            <a href="#step-1" type="button" class="btn btn-primary btn-circle">1</a>
            <p>Step 1</p>
        </div>
        <div class="stepwizard-step">
            <a href="#step-2" type="button" class="btn btn-default btn-circle" disabled="disabled">2</a>
            <p>Step 2</p>
        </div>
        <div class="stepwizard-step">
            <a href="#step-3" type="button" class="btn btn-default btn-circle" disabled="disabled">3</a>
            <p>Step 3</p>
        </div>
    </div>
</div>
<form role="form" runat="server">
    <div class="row setup-content" id="step-1">
        <div class="col-xs-12">
            <div class="col-md-12">
                <h3> Step 1</h3>
                <div class="form-group">
                    <label class="control-label">Nom :</label>
                    <input  maxlength="100" id="nomC" runat="server" type="text" required="required" class="form-control" placeholder="Veuillez Saisir votre nom svp"  />
                </div>
                <div class="form-group">
                    <label class="control-label">Prénom :</label>
                    <input maxlength="100" id="prenomC" runat="server" type="text" required="required" class="form-control" placeholder="Veuillez saisir votre prénom svp" />
                </div>
                <div class="form-group">
                    <label class="control-label">N° de passport :</label>
                    <input maxlength="100" id="numPass" runat="server" type="text" required="required" class="form-control" placeholder="Veuillez saisir votre N° de passport svp" />
                </div>
                <div class="form-group">
                    <label class="control-label">N° de téléphone :</label>
                    <input maxlength="100" id="numTel" runat="server" type="text" required="required" class="form-control" placeholder="Veuillez saisir votre N° de téléphone svp" />
                </div>
                <div class="form-group">
                    <label class="control-label">Date de naissance :</label>
                    <input maxlength="100" id="dateNaiss" runat="server" type="text" required="required" class="form-control" placeholder="Veuillez marquer votre date de naissance svp" />
                </div>
                <button class="btn btn-primary nextBtn btn-lg pull-right" type="button" >Next</button>
            </div>
        </div>
    </div>
    <div class="row setup-content" id="step-2">
        <div class="col-xs-12">
            <div class="col-md-12">
                <h3> Step 2</h3>
                <div class="form-group">
                    <label class="control-label" >Numéro de carte bancaire :</label>
                    <input maxlength="200" id="numCarte" runat="server" type="text" required="required" class="form-control" placeholder="Veuillez introduire votre numéro de CB svp" />
                </div>
                <div class="form-group">
                    <label class="control-label">CVV :</label>
                    <input maxlength="200" id="cVV" runat="server" type="text" required="required" class="form-control" placeholder="Veuillez intoduire votre CVV svp"  />
                </div>
                <div class="form-group">
                    <label class="control-label">Type de carte :</label>
                    <input maxlength="200" id="typeCarte" runat="server" type="text" required="required" class="form-control" placeholder="Ex : CB, VISA, VISA ELECTRON, MASTERCARD, PAYONEER.."  />
                </div>
                <div class="form-group">
                    <label class="control-label">Date d'expiration de la carte :</label>
                    <input maxlength="200" id="dateExpi" runat="server" type="text" required="required" class="form-control" placeholder="Veuillez intoduire la date d'expiration"  />
                </div>
                <button class="btn btn-primary nextBtn btn-lg pull-right" type="button" >Next</button>
            </div>
        </div>
    </div>
    <div class="row setup-content" id="step-3">
        <div class="col-xs-12">
            <div class="col-md-12">
                <h3> Step 3</h3>
                <button class="btn btn-success btn-lg pull-right" id="btnFinish" type="submit" runat="server" onserverClick="btnFinish_Click">Finish!</button>
            </div>
        </div>
    </div>
</form>
</div>
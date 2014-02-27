<!DOCTYPE html>
<!--[if lt IE 7]>      <html class="no-js lt-ie9 lt-ie8 lt-ie7"> <![endif]-->
<!--[if IE 7]>         <html class="no-js lt-ie9 lt-ie8"> <![endif]-->
<!--[if IE 8]>         <html class="no-js lt-ie9"> <![endif]-->
<!--[if gt IE 8]><!--> <html class="no-js"> <!--<![endif]-->
    <head>
        <meta charset="utf-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
        <title></title>
        <meta name="description" content="">
        <meta name="viewport" content="width=device-width">
        <link rel="stylesheet" href="web/css/bootstrap.min.css">
        <link rel="stylesheet" href="web/css/bootstrap-theme.min.css">
        <link rel="stylesheet" href="web/css/main.css">

        <script src="web/js/vendor/modernizr-2.6.2-respond-1.1.0.min.js"></script>


    </head>
    <body>
        <!--[if lt IE 7]>
            <p class="chromeframe">You are using an <strong>outdated</strong> browser. Please <a href="http://browsehappy.com/">upgrade your browser</a> or <a href="http://www.google.com/chromeframe/?redirect=true">activate Google Chrome Frame</a> to improve your experience.</p>
        <![endif]-->

        <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="#">Profiles Book</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li class="active"><a id="home-link" onclick="getLoginForm()" href="#home">Home</a></li>
                        <li><a href="#profile" id="profile-link" data-userid="52a1a04af7c2bfec07d63af1">Profile</a></li>
                    </ul>
                    <ul class="nav navbar-nav navbar-right">
                        <li><a href="#contact" id="contact-link">Contact</a></li>
                    </ul>

                </div><!--/.navbar-collapse -->

            </div><!--/.navbar-collapse -->
        </div>
    </div>


    <div class="container">
        <div class="row">
            
            <div class="col-md-12">
                <div id="loginsubscribefroms" class="panel panel-default">
                    <div class="panel-body">Login</div>
                    <div class="panel-footer">
                        <form class="form-horizontal login" role="form">
                            <div class="form-group">
                                <label for="inputEmail3" class="col-sm-2 control-label">Email</label>
                                <div class="col-sm-10">
                                    <input type="email" class="form-control" id="inputEmail3" placeholder="Email">
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="inputPassword3" class="col-sm-2 control-label">Mot de passe</label>
                                <div class="col-sm-10">
                                    <input type="password" class="form-control" id="inputPassword3" placeholder="Password">
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-offset-2 col-sm-10">
                                    <div class="checkbox">
                                        <label>
                                            <input type="checkbox"> Remember me
                                        </label>
                                    </div>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-offset-2 col-sm-10">
                                    <button class="btn btn-default" id="login-account-link">Sign in</button>
                                    or <a href="#registration" id="create-account-link">create account</a>
                                </div>
                            </div>
                        </form>

                    </div>
                </div>

            </div>
        </div>
    </div> 

    <!-- /container -->        
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.10.1/jquery.min.js"></script>
    <script>window.jQuery || document.write('<script src="web/js/vendor/jquery-1.10.1.min.js"><\/script>')</script>
    <script src="web/js/vendor/bootstrap.min.js"></script>
    <script type="text/javascript" src="web/js/vendor/jquery.noty.js"></script>
    <script type="text/javascript" src="web/js/vendor/bottom.js"></script>
    <script type="text/javascript" src="web/js/vendor/default.js"></script>
    <script src="web/js/main.js"></script>
</body>
</html>
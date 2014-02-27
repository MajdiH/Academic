<?php

require(__DIR__ . '/controller.php');
require(__DIR__ . '/../Models/class.User.php');


if (isset($_POST['locate'])) {

    $locate = $_POST['locate'];

    switch ($locate):

        case 'GetLoginForm':
            $view = getView('user', 'login');
            echo $view;
            break;

        case 'GetProfileForm':
            $defaultuser = new User(Array());
            $user= $defaultuser->getUser($_POST['userid']);
            $html = '';
            $html .='<div class="panel-body">Update my profile</div>
            <div class="panel-footer">
                <form class="form-horizontal login" role="form">
                    <div class="form-group">
                        <label for="inputFirstName3" class="col-sm-2 control-label">Avatar</label>
                        <div class="col-sm-10">
                            <img src="http://twistedsifter.files.wordpress.com/2012/09/trippy-profile-pic-portrait-head-on-and-from-side-angle.jpg" alt="" width="200" class="img-thumbnail">
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="inputFirstName3" class="col-sm-2 control-label">First name</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="inputFirstName3" value="'.$user->getUser_first().'">
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="inputLastName3" class="col-sm-2 control-label">Last name</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="inputLastName3" placeholder="Last name" value="'.$user->getUser_last().'">
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="inputBirthday3" class="col-sm-2 control-label">Birthday</label>
                        <div class="col-sm-10">
                            <input type="date" class="form-control" id="inputBirthday3" placeholder="Birthday"  value="'.$user->getUser_birthday().'">
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="inputPhone3" class="col-sm-2 control-label">Phone</label>
                        <div class="col-sm-10">
                            <input type="tel" pattern="^((\+\d{1,3}(-| )?\(?\d\)?(-| )?\d{1,5})|(\(?\d{2,6}\)?))(-| )?(\d{3,4})(-| )?(\d{4})(( x| ext)\d{1,5}){0,1}$" class="form-control" id="inputPhone3" placeholder="Phone"  value="'.$user->getUser_phone().'">
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-sm-offset-2 col-sm-10">
                            <button id="update-user-link" class="btn btn-default">Save</button>
                        </div>
                    </div>
                </form>
            </div>';
            echo $html;
            break;

        case 'GetCreateAcountForm':
            $view = getView('user', 'registration');
            echo $view;
            break;

        case 'AddNewUser':
            $data = array('user_first' => $_POST['fname'], 'user_last' => $_POST['lname'], 'user_birthday' => $_POST['birthday'], 'user_phone' => $_POST['phone'], 'user_email' => $_POST['email'], 'user_pwd' => $_POST['password']);
            $user = new User($data);
            $user->add($user->getUserArray());
            $view = getView('user', 'login');
            echo $view;
            break;
        
        case 'UserLogin':
            $data = array('user_email' => $_POST['email'], 'user_pwd' => $_POST['password']);
            $user = new User($data);
            $userid = $user->userLogin($user);
            echo $userid['_id'];
//            $user = $user->getUser($userid['_id']);
            break;
        

        default:
            echo "Never Mind";

    endswitch;
}
?>

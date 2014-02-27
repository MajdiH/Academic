<?php

/**
 * Description of class
 *
 * @author majdih
 */
class User {

    protected $user_id;
    protected $user_first;
    protected $user_last;
    protected $user_birthday;
    protected $user_phone;
    protected $user_email;
    protected $user_pwd;

    public function __construct(array $data) {
        $this->hydrate($data);
    }

# FUNCTIONS TO RETRIEVE INFO - DESERIALIZE.

    public function hydrate(array $data) {
        foreach ($data as $key => $value) {
            $method = 'set' . ucfirst($key);

            if (method_exists($this, $method)) {
                $this->$method($value);
            }
        }
    }

# FUNCTIONS TO SAVE INFO - SERIALIZE.

    public function add($user) {
        $m = new MongoClient();
        $db = $m->profilesbook;
        $collection = $db->users;
        $collection->insert($user);
        $this->setUserID($user['_id']);
    }
    
    public function userLogin(User $user){
        $m = new MongoClient();
        $collection = $m->profilesbook->users;
        $userArray = $collection->findOne(array('user_email' => $user->getUser_email()), array('user_pwd' => $user->getUser_pwd()));
        return $userArray;
    }

    public function getUser($userid) {
        $m = new MongoClient();
        $users = $m->profilesbook->users;
        $userArray = $users->findOne(array('_id' => new MongoId($userid)));
        $user = new User($userArray);
        $user->setUserID($userid);
        return $user;
    }

# GETTER and SETTER FUNCTIONS - DO NOT ALLOW SETTING OF ID

    public function getUserArray() {
        $array = array();
        foreach ($this as $key => $value) {
            $method = 'get' . ucfirst($key);
            if (method_exists($this, $method)) {
                $array[$key] = $this->$method($value);
            }
        }
        return $array;
    }

    public function setUserID($user_id) {
        $this->user_id = $user_id;
    }

    public function getUser_first() {
        return $this->user_first;
    }

    public function setUser_first($user_first) {
        $this->user_first = $user_first;
    }

    public function getUser_last() {
        return $this->user_last;
    }

    public function setUser_last($user_last) {
        $this->user_last = $user_last;
    }

    public function getUser_birthday() {
        return $this->user_birthday;
    }

    public function setUser_birthday($user_birthday) {
        $this->user_birthday = $user_birthday;
    }

    public function getUser_phone() {
        return $this->user_phone;
    }

    public function setUser_phone($user_phone) {
        $this->user_phone = $user_phone;
    }

    public function getUser_email() {
        return $this->user_email;
    }

    public function setUser_email($user_email) {
        $this->user_email = $user_email;
    }

    public function getUser_pwd() {
        return $this->user_pwd;
    }

    public function setUser_pwd($user_pwd) {
        $this->user_pwd = $user_pwd;
    }

}
?>

class UserSession {
    constructor({token, user}) {
        this.token = token;
        this.user = new User(user);
    }
}

class User {
    constructor({id, email, password, roles,
        last_name, first_name, middle_name
    } = {}) {
        this.id = id;
        this.email = email;
        this.password = password;
        this.roles = roles || [];
        this.last_name = last_name || '';
        this.first_name = first_name || '';
        this.middle_name = middle_name || '';
    }

    beforeSave() {
    }


    set selectedRole(role) {
        this.roles = [role];
    }

    get selectedRole() {
        return this.roles[0];
    }

    get fio() {
        let name = this.last_name.trim() + ' ' + this.first_name.trim();
        let fio = name.trim() + ' ' + this.middle_name.trim();
        return fio.trim();
    }
}

export {UserSession};
export default User;
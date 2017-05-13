class File {
    constructor({id, name, path, full_path, original_name, created} = {}) {
        this.id = id;
        this.name = name;
        this.path = path;
        this.original_name = original_name;
        this.created = created ? moment(created, "YYYY-MM-DD HH:mm:ss") : moment();
        this.full_path = full_path;
    }
}

export default File;
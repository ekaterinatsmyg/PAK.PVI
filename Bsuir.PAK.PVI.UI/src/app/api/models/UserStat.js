class UserStat {
    constructor({total_count, count_entered, average_session_time, roles, cohorts} = {}) {
        this.total_count = total_count || 0;
        this.count_entered = count_entered || 0;

        this.average_session_time = this.setDateByFormat('hh:mm', average_session_time);
        this.roles = roles || {};
        this.cohorts = cohorts || [];
    }

    setDateByFormat(format, date) {
        let result = '';
        if(date) {
            switch(format) {
                case 'hh:mm': {
                    let h = Math.floor(date / 3600);
                    let hh = (h < 10) ? ('0' + h) : h;
                    let m = Math.round((date / 60) % 60);
                    let mm = (m < 10) ? ('0' + m) : m;
                    result = `${hh}:${mm}`;
                } break;
                default: break;
            }
        }

        return result;
    }
}

export default UserStat;

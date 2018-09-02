class DAL {
    constructor(config) {
        this.Url = config.url;
    }

    SearchPages(search) {
        debugger;
        return fetch(this.Url + '/Page/' + (search || ''), {
            method: 'GET',
            cache: "no-cache",
            redirect: "follow",
            referrer: "no-referrer",
            credentials: "same-origin",
            headers: {
                "Content-type": "application/json; charset=UTF-8"
            },
        });
    };

    GetTranslation(id) {
        return fetch(this.Url + '/Translation/' + (id), {
            method: 'GET',
            cache: "no-cache",
            redirect: "follow",
            referrer: "no-referrer",
            credentials: "same-origin",
            headers: {
                "Content-type": "application/json; charset=UTF-8"
            },
        }).catch((error) => {
            console.log(error)
        });
    };
}

module.exports = {
    DAL
};
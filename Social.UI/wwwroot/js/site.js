var app = new Vue({
    el: "#app",
    methods: {

        onSubmit(e) {
            const file = this.$refs.file.files[0];

            if (!file) {
                e.preventDefault();
                alert('No file chosen');
                return;
            }

            if (file.size > 1024 * 1024) {
                e.preventDefault();
                alert('File too big (> 1MB)');
                return;
            }

            alert('File OK');
        }
    }
})
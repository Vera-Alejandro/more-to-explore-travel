<template>
  <div class="container flex flex-col items-center">

    <div>
      <h1 class="text-3xl text-center my-5">Get in Touch!</h1>
    </div>
    <div>
      <h1 class="text-center"> {{ welcomeText }} </h1>
    </div>
    <div>
      <v-btn class="my-10"> Contact Me </v-btn>
    </div>



  </div>
</template>

<script>
import { validationMixin } from "vuelidate";
import { required, maxLength, email } from "vuelidate/lib/validators";

export default {
  mixins: [validationMixin],

  validations: {
    name: { required, maxLength: maxLength(25) },
    email: { required, email },
    message: { required },
  },

  name: "LetsGetInTouch",
  components: {},
  data() {
    return {
      welcomeText: "pharetra eu mi vel, dignissim ultricies magna. Quisque ut interdum libero, sed euismod nulla. Sed varius, nibh id placerat mattis, nulla enim interdum erat, ut fermentum sem leo ac ex. Fusce vel lobortis mi, vitae dignissim velit. Praesent mollis in neque nec mollis. Curabitur a mi facilisis, varius tortor vel, rhoncus sem.",
      name: "",
      email: "",
      message: "",
      inDevAlert: false,
    };
  },
  computed: {
    nameErrors() {
      const errors = [];

      if (!this.$v.name.$dirty) return errors;
      !this.$v.name.maxLength &&
        errors.push("Name must be at most 10 characters long");
      !this.$v.name.required && errors.push("Name is required.");

      return errors;
    },
    emailErrors() {
      const errors = [];

      if (!this.$v.email.$dirty) return errors;
      !this.$v.email.email && errors.push("Must be valid e-mail");
      !this.$v.email.required && errors.push("E-mail is required");

      return errors;
    },
    messageErrors() {
      const errors = [];

      if (!this.$v.message.$dirty) return errors;
      !this.$v.message.required && errors.push("E-mail is required");

      return errors;
    },
  },
  methods: {
    submit() {
      this.inDevAlert = true;
      return;
      // this.$v.touch();
    },
  },
};
</script>

<style scoped>
.title-row {
  justify-content: center;
}

.form-group {
  background-color: whitesmoke;
  max-width: 780px;
  margin: 0 auto;
  border-radius: 10px;
  padding-bottom: 1.5rem;
}

.contact {
  padding: 2rem;
  height: 35rem;
  margin: 0;
  max-width: 100%;
  background-size: cover;
}

.input-form {
  align-items: center;
  text-align: center;
  padding: 0 15px;
}

.alerts {
  position: absolute;
  bottom: 0px;
}

h2 {
  text-align: center;
  font-family: "Satisfy", cursor;
  font-size: 3rem;
  font-weight: 200;
}
</style>
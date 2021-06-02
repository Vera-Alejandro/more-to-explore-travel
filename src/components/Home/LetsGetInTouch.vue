<template>
  <div class="container contact">
    <div>
      <h2>Let's Get In Touch!</h2>
      <div>
        <form class="input-form">
          <v-text-field
            v-model="name"
            :error-messages="nameErrors"
            :counter="25"
            label="Name"
            required
            background-color="white"
            @input="$v.name.$touch()"
            @blur="$v.name.$touch()"
          ></v-text-field>
          <v-text-field
            v-model="email"
            :error-messages="emailErrors"
            label="E-mail"
            required
            @input="$v.email.$touch()"
            @blur="$v.email.$touch()"
          ></v-text-field>
          <v-textarea
            v-model="message"
            :error-messages="messageErrors"
            label="Message"
            required
            class="text-justify"
            @change="$v.select.$touch()"
            @blur="$v.select.$touch()"
          ></v-textarea>

          <v-btn class="mr-4" @click="submit"> submit </v-btn>
        </form>
      </div>

      <v-snackbar v-model="inDevAlert">
        'Let's Get In Touch' is still in development.
        <template v-slot:action="{ attrs }">
          <v-btn color="green" text v-bind="attrs" @click="inDevAlert = false">
            Close
          </v-btn>
        </template>
      </v-snackbar>

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
.text-wrap {
  color: black;
}

.contact {
  padding: 2rem;
  height: 30rem;
  margin: 0;
  max-width: 100%;
  background-size: cover;
}

.input-form {
  max-width: 750px;
  align-items: center;
  margin: 0 auto;
}
h2 {
  text-align: center;
}
</style>
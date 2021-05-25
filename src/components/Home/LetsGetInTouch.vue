<template>
  <div class="container contact">
    <div>
      <h2>Let's Get in Touch!</h2>
      <div>
        <form>
          <v-text-field
            v-model="name"
            :error-messages="nameErrors"
            :counter="25"
            label="Name"
            required
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
          <v-select
            v-model="message"
            :error-messages="messageErrors"
            label="Message"
            required
            @change="$v.select.$touch()"
            @blur="$v.select.$touch()"
          ></v-select>

          <v-btn class="mr-4" @click="submit"> submit </v-btn>
        </form>
      </div>
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
    };
  },
  computed: {
      nameErrors () {
        const errors = []

        if (!this.$v.name.$dirty) return errors
        !this.$v.name.maxLength && errors.push('Name must be at most 10 characters long')
        !this.$v.name.required && errors.push('Name is required.')
        
        return errors
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
      this.$v.touch();
    },
  },
};
</script>

<style>
</style>
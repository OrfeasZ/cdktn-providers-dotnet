using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace acme.Registration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/registration acme_registration}.</summary>
    [JsiiClass(nativeType: typeof(acme.Registration.Registration), fullyQualifiedName: "acme.registration.Registration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"acme.registration.RegistrationConfig\"}}]")]
    public class Registration : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/registration acme_registration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Registration(Constructs.Construct scope, string id, acme.Registration.IRegistrationConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, acme.Registration.IRegistrationConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Registration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Registration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a Registration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Registration to import.</param>
        /// <param name="importFromId">The id of the existing Registration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Registration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Registration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/vancluever/acme/2.48.0/docs/resources/registration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Registration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Registration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(acme.Registration.Registration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putExternalAccountBinding", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"acme.registration.RegistrationExternalAccountBinding\"}}]")]
        public virtual void PutExternalAccountBinding(acme.Registration.IRegistrationExternalAccountBinding @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(acme.Registration.IRegistrationExternalAccountBinding)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccountKeyAlgorithm")]
        public virtual void ResetAccountKeyAlgorithm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAccountKeyEcdsaCurve")]
        public virtual void ResetAccountKeyEcdsaCurve()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAccountKeyPem")]
        public virtual void ResetAccountKeyPem()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAccountKeyRsaBits")]
        public virtual void ResetAccountKeyRsaBits()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailAddress")]
        public virtual void ResetEmailAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExternalAccountBinding")]
        public virtual void ResetExternalAccountBinding()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(acme.Registration.Registration))!;

        [JsiiProperty(name: "externalAccountBinding", typeJson: "{\"fqn\":\"acme.registration.RegistrationExternalAccountBindingOutputReference\"}")]
        public virtual acme.Registration.RegistrationExternalAccountBindingOutputReference ExternalAccountBinding
        {
            get => GetInstanceProperty<acme.Registration.RegistrationExternalAccountBindingOutputReference>()!;
        }

        [JsiiProperty(name: "registrationUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegistrationUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountKeyAlgorithmInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountKeyAlgorithmInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountKeyEcdsaCurveInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountKeyEcdsaCurveInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountKeyPemInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountKeyPemInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountKeyRsaBitsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AccountKeyRsaBitsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalAccountBindingInput", typeJson: "{\"fqn\":\"acme.registration.RegistrationExternalAccountBinding\"}", isOptional: true)]
        public virtual acme.Registration.IRegistrationExternalAccountBinding? ExternalAccountBindingInput
        {
            get => GetInstanceProperty<acme.Registration.IRegistrationExternalAccountBinding?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountKeyAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountKeyAlgorithm
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "accountKeyEcdsaCurve", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountKeyEcdsaCurve
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "accountKeyPem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountKeyPem
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "accountKeyRsaBits", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AccountKeyRsaBits
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emailAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

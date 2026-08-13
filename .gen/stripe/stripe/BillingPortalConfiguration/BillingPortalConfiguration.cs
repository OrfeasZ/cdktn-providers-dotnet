using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingPortalConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration stripe_billing_portal_configuration}.</summary>
    [JsiiClass(nativeType: typeof(stripe.BillingPortalConfiguration.BillingPortalConfiguration), fullyQualifiedName: "stripe.billingPortalConfiguration.BillingPortalConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationConfig\"}}]")]
    public class BillingPortalConfiguration : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration stripe_billing_portal_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public BillingPortalConfiguration(Constructs.Construct scope, string id, stripe.BillingPortalConfiguration.IBillingPortalConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.BillingPortalConfiguration.IBillingPortalConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BillingPortalConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BillingPortalConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a BillingPortalConfiguration resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the BillingPortalConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing BillingPortalConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the BillingPortalConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the BillingPortalConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing BillingPortalConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the BillingPortalConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.BillingPortalConfiguration.BillingPortalConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBusinessProfile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationBusinessProfile\"}}]")]
        public virtual void PutBusinessProfile(stripe.BillingPortalConfiguration.IBillingPortalConfigurationBusinessProfile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.BillingPortalConfiguration.IBillingPortalConfigurationBusinessProfile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFeatures", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeatures\"}}]")]
        public virtual void PutFeatures(stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeatures @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeatures)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLoginPage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationLoginPage\"}}]")]
        public virtual void PutLoginPage(stripe.BillingPortalConfiguration.IBillingPortalConfigurationLoginPage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.BillingPortalConfiguration.IBillingPortalConfigurationLoginPage)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActive")]
        public virtual void ResetActive()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBusinessProfile")]
        public virtual void ResetBusinessProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultReturnUrl")]
        public virtual void ResetDefaultReturnUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoginPage")]
        public virtual void ResetLoginPage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
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
        = GetStaticProperty<string>(typeof(stripe.BillingPortalConfiguration.BillingPortalConfiguration))!;

        [JsiiProperty(name: "application", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Application
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "businessProfile", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationBusinessProfileOutputReference\"}")]
        public virtual stripe.BillingPortalConfiguration.BillingPortalConfigurationBusinessProfileOutputReference BusinessProfile
        {
            get => GetInstanceProperty<stripe.BillingPortalConfiguration.BillingPortalConfigurationBusinessProfileOutputReference>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Created
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "features", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesOutputReference\"}")]
        public virtual stripe.BillingPortalConfiguration.BillingPortalConfigurationFeaturesOutputReference Features
        {
            get => GetInstanceProperty<stripe.BillingPortalConfiguration.BillingPortalConfigurationFeaturesOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isDefault", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDefault
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "livemode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Livemode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "loginPage", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationLoginPageOutputReference\"}")]
        public virtual stripe.BillingPortalConfiguration.BillingPortalConfigurationLoginPageOutputReference LoginPage
        {
            get => GetInstanceProperty<stripe.BillingPortalConfiguration.BillingPortalConfigurationLoginPageOutputReference>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "activeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ActiveInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.BillingPortalConfiguration.IBillingPortalConfigurationBusinessProfile" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "businessProfileInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationBusinessProfile\"}]}}", isOptional: true)]
        public virtual object? BusinessProfileInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultReturnUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultReturnUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeatures" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "featuresInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeatures\"}]}}", isOptional: true)]
        public virtual object? FeaturesInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.BillingPortalConfiguration.IBillingPortalConfigurationLoginPage" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "loginPageInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationLoginPage\"}]}}", isOptional: true)]
        public virtual object? LoginPageInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "active", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Active
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "defaultReturnUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultReturnUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

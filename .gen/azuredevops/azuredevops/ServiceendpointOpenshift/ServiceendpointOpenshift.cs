using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.ServiceendpointOpenshift
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_openshift azuredevops_serviceendpoint_openshift}.</summary>
    [JsiiClass(nativeType: typeof(azuredevops.ServiceendpointOpenshift.ServiceendpointOpenshift), fullyQualifiedName: "azuredevops.serviceendpointOpenshift.ServiceendpointOpenshift", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuredevops.serviceendpointOpenshift.ServiceendpointOpenshiftConfig\"}}]")]
    public class ServiceendpointOpenshift : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_openshift azuredevops_serviceendpoint_openshift} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ServiceendpointOpenshift(Constructs.Construct scope, string id, azuredevops.ServiceendpointOpenshift.IServiceendpointOpenshiftConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuredevops.ServiceendpointOpenshift.IServiceendpointOpenshiftConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceendpointOpenshift(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceendpointOpenshift(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ServiceendpointOpenshift resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ServiceendpointOpenshift to import.</param>
        /// <param name="importFromId">The id of the existing ServiceendpointOpenshift that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ServiceendpointOpenshift to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ServiceendpointOpenshift to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/serviceendpoint_openshift#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ServiceendpointOpenshift that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ServiceendpointOpenshift to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azuredevops.ServiceendpointOpenshift.ServiceendpointOpenshift), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAuthBasic", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointOpenshift.ServiceendpointOpenshiftAuthBasic\"}}]")]
        public virtual void PutAuthBasic(azuredevops.ServiceendpointOpenshift.IServiceendpointOpenshiftAuthBasic @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointOpenshift.IServiceendpointOpenshiftAuthBasic)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthNone", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointOpenshift.ServiceendpointOpenshiftAuthNone\"}}]")]
        public virtual void PutAuthNone(azuredevops.ServiceendpointOpenshift.IServiceendpointOpenshiftAuthNone @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointOpenshift.IServiceendpointOpenshiftAuthNone)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAuthToken", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointOpenshift.ServiceendpointOpenshiftAuthToken\"}}]")]
        public virtual void PutAuthToken(azuredevops.ServiceendpointOpenshift.IServiceendpointOpenshiftAuthToken @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointOpenshift.IServiceendpointOpenshiftAuthToken)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.serviceendpointOpenshift.ServiceendpointOpenshiftTimeouts\"}}]")]
        public virtual void PutTimeouts(azuredevops.ServiceendpointOpenshift.IServiceendpointOpenshiftTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.ServiceendpointOpenshift.IServiceendpointOpenshiftTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAcceptUntrustedCerts")]
        public virtual void ResetAcceptUntrustedCerts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthBasic")]
        public virtual void ResetAuthBasic()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthNone")]
        public virtual void ResetAuthNone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthToken")]
        public virtual void ResetAuthToken()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificateAuthorityFile")]
        public virtual void ResetCertificateAuthorityFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerUrl")]
        public virtual void ResetServerUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(azuredevops.ServiceendpointOpenshift.ServiceendpointOpenshift))!;

        [JsiiProperty(name: "authBasic", typeJson: "{\"fqn\":\"azuredevops.serviceendpointOpenshift.ServiceendpointOpenshiftAuthBasicOutputReference\"}")]
        public virtual azuredevops.ServiceendpointOpenshift.ServiceendpointOpenshiftAuthBasicOutputReference AuthBasic
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointOpenshift.ServiceendpointOpenshiftAuthBasicOutputReference>()!;
        }

        [JsiiProperty(name: "authNone", typeJson: "{\"fqn\":\"azuredevops.serviceendpointOpenshift.ServiceendpointOpenshiftAuthNoneOutputReference\"}")]
        public virtual azuredevops.ServiceendpointOpenshift.ServiceendpointOpenshiftAuthNoneOutputReference AuthNone
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointOpenshift.ServiceendpointOpenshiftAuthNoneOutputReference>()!;
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Authorization
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "authToken", typeJson: "{\"fqn\":\"azuredevops.serviceendpointOpenshift.ServiceendpointOpenshiftAuthTokenOutputReference\"}")]
        public virtual azuredevops.ServiceendpointOpenshift.ServiceendpointOpenshiftAuthTokenOutputReference AuthToken
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointOpenshift.ServiceendpointOpenshiftAuthTokenOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.serviceendpointOpenshift.ServiceendpointOpenshiftTimeoutsOutputReference\"}")]
        public virtual azuredevops.ServiceendpointOpenshift.ServiceendpointOpenshiftTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointOpenshift.ServiceendpointOpenshiftTimeoutsOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "acceptUntrustedCertsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AcceptUntrustedCertsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authBasicInput", typeJson: "{\"fqn\":\"azuredevops.serviceendpointOpenshift.ServiceendpointOpenshiftAuthBasic\"}", isOptional: true)]
        public virtual azuredevops.ServiceendpointOpenshift.IServiceendpointOpenshiftAuthBasic? AuthBasicInput
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointOpenshift.IServiceendpointOpenshiftAuthBasic?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authNoneInput", typeJson: "{\"fqn\":\"azuredevops.serviceendpointOpenshift.ServiceendpointOpenshiftAuthNone\"}", isOptional: true)]
        public virtual azuredevops.ServiceendpointOpenshift.IServiceendpointOpenshiftAuthNone? AuthNoneInput
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointOpenshift.IServiceendpointOpenshiftAuthNone?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authTokenInput", typeJson: "{\"fqn\":\"azuredevops.serviceendpointOpenshift.ServiceendpointOpenshiftAuthToken\"}", isOptional: true)]
        public virtual azuredevops.ServiceendpointOpenshift.IServiceendpointOpenshiftAuthToken? AuthTokenInput
        {
            get => GetInstanceProperty<azuredevops.ServiceendpointOpenshift.IServiceendpointOpenshiftAuthToken?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateAuthorityFileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateAuthorityFileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "projectIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServerUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceEndpointNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceEndpointNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azuredevops.ServiceendpointOpenshift.IServiceendpointOpenshiftTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azuredevops.serviceendpointOpenshift.ServiceendpointOpenshiftTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "acceptUntrustedCerts", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AcceptUntrustedCerts
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

        [JsiiProperty(name: "certificateAuthorityFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateAuthorityFile
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
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

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serverUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceEndpointName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceEndpointName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

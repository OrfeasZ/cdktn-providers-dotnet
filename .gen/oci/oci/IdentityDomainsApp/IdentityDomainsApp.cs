using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app oci_identity_domains_app}.</summary>
    [JsiiClass(nativeType: typeof(oci.IdentityDomainsApp.IdentityDomainsApp), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsApp", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppConfig\"}}]")]
    public class IdentityDomainsApp : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app oci_identity_domains_app} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IdentityDomainsApp(Constructs.Construct scope, string id, oci.IdentityDomainsApp.IIdentityDomainsAppConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.IdentityDomainsApp.IIdentityDomainsAppConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsApp(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IdentityDomainsApp(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a IdentityDomainsApp resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the IdentityDomainsApp to import.</param>
        /// <param name="importFromId">The id of the existing IdentityDomainsApp that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the IdentityDomainsApp to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the IdentityDomainsApp to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing IdentityDomainsApp that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the IdentityDomainsApp to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.IdentityDomainsApp.IdentityDomainsApp), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAliasApps", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAliasApps\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAliasApps(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsApp.IIdentityDomainsAppAliasApps[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppAliasApps).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppAliasApps).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAllowedScopes", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAllowedScopes\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAllowedScopes(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsApp.IIdentityDomainsAppAllowedScopes[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppAllowedScopes).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppAllowedScopes).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAllowedTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAllowedTags\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAllowedTags(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsApp.IIdentityDomainsAppAllowedTags[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppAllowedTags).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppAllowedTags).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAppSignonPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAppSignonPolicy\"}}]")]
        public virtual void PutAppSignonPolicy(oci.IdentityDomainsApp.IIdentityDomainsAppAppSignonPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppAppSignonPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAppsNetworkPerimeters", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAppsNetworkPerimeters\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAppsNetworkPerimeters(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsApp.IIdentityDomainsAppAppsNetworkPerimeters[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppAppsNetworkPerimeters).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppAppsNetworkPerimeters).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAsOpcService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAsOpcService\"}}]")]
        public virtual void PutAsOpcService(oci.IdentityDomainsApp.IIdentityDomainsAppAsOpcService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppAsOpcService)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAttrRenderingMetadata", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAttrRenderingMetadata\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAttrRenderingMetadata(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsApp.IIdentityDomainsAppAttrRenderingMetadata[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppAttrRenderingMetadata).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppAttrRenderingMetadata).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBasedOnTemplate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppBasedOnTemplate\"}}]")]
        public virtual void PutBasedOnTemplate(oci.IdentityDomainsApp.IIdentityDomainsAppBasedOnTemplate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppBasedOnTemplate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCertificates", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppCertificates\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCertificates(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsApp.IIdentityDomainsAppCertificates[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppCertificates).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppCertificates).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentityProviders", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppIdentityProviders\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIdentityProviders(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsApp.IIdentityDomainsAppIdentityProviders[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppIdentityProviders).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppIdentityProviders).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdpPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppIdpPolicy\"}}]")]
        public virtual void PutIdpPolicy(oci.IdentityDomainsApp.IIdentityDomainsAppIdpPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppIdpPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProtectableSecondaryAudiences", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppProtectableSecondaryAudiences\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutProtectableSecondaryAudiences(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsApp.IIdentityDomainsAppProtectableSecondaryAudiences[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppProtectableSecondaryAudiences).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppProtectableSecondaryAudiences).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRadiusPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppRadiusPolicy\"}}]")]
        public virtual void PutRadiusPolicy(oci.IdentityDomainsApp.IIdentityDomainsAppRadiusPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppRadiusPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSamlServiceProvider", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppSamlServiceProvider\"}}]")]
        public virtual void PutSamlServiceProvider(oci.IdentityDomainsApp.IIdentityDomainsAppSamlServiceProvider @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppSamlServiceProvider)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScopes", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppScopes\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutScopes(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsApp.IIdentityDomainsAppScopes[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppScopes).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppScopes).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceParams", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppServiceParams\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutServiceParams(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsApp.IIdentityDomainsAppServiceParams[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppServiceParams).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppServiceParams).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSignonPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppSignonPolicy\"}}]")]
        public virtual void PutSignonPolicy(oci.IdentityDomainsApp.IIdentityDomainsAppSignonPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppSignonPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppTags\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTags(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsApp.IIdentityDomainsAppTags[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppTags).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppTags).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTermsOfUse", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppTermsOfUse\"}}]")]
        public virtual void PutTermsOfUse(oci.IdentityDomainsApp.IIdentityDomainsAppTermsOfUse @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppTermsOfUse)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.IdentityDomainsApp.IIdentityDomainsAppTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTrustPolicies", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppTrustPolicies\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTrustPolicies(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.IdentityDomainsApp.IIdentityDomainsAppTrustPolicies[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppTrustPolicies).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppTrustPolicies).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrnietfparamsscimschemasoracleidcsextensiondbcsApp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensiondbcsApp\"}}]")]
        public virtual void PutUrnietfparamsscimschemasoracleidcsextensiondbcsApp(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensiondbcsApp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensiondbcsApp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp\"}}]")]
        public virtual void PutUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrnietfparamsscimschemasoracleidcsextensionformFillAppApp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppApp\"}}]")]
        public virtual void PutUrnietfparamsscimschemasoracleidcsextensionformFillAppApp(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppApp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppApp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate\"}}]")]
        public virtual void PutUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp\"}}]")]
        public virtual void PutUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrnietfparamsscimschemasoracleidcsextensionmanagedappApp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappApp\"}}]")]
        public virtual void PutUrnietfparamsscimschemasoracleidcsextensionmanagedappApp(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappApp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappApp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp\"}}]")]
        public virtual void PutUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrnietfparamsscimschemasoracleidcsextensionOciTags", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionOciTags\"}}]")]
        public virtual void PutUrnietfparamsscimschemasoracleidcsextensionOciTags(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionOciTags @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionOciTags)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrnietfparamsscimschemasoracleidcsextensionopcServiceApp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceApp\"}}]")]
        public virtual void PutUrnietfparamsscimschemasoracleidcsextensionopcServiceApp(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceApp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceApp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrnietfparamsscimschemasoracleidcsextensionradiusAppApp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp\"}}]")]
        public virtual void PutUrnietfparamsscimschemasoracleidcsextensionradiusAppApp(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrnietfparamsscimschemasoracleidcsextensionrequestableApp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableApp\"}}]")]
        public virtual void PutUrnietfparamsscimschemasoracleidcsextensionrequestableApp(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableApp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableApp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp\"}}]")]
        public virtual void PutUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp\"}}]")]
        public virtual void PutUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessTokenExpiry")]
        public virtual void ResetAccessTokenExpiry()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetActive")]
        public virtual void ResetActive()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAliasApps")]
        public virtual void ResetAliasApps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowAccessControl")]
        public virtual void ResetAllowAccessControl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowedGrants")]
        public virtual void ResetAllowedGrants()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowedOperations")]
        public virtual void ResetAllowedOperations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowedScopes")]
        public virtual void ResetAllowedScopes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowedTags")]
        public virtual void ResetAllowedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowOffline")]
        public virtual void ResetAllowOffline()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllUrlSchemesAllowed")]
        public virtual void ResetAllUrlSchemesAllowed()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAppIcon")]
        public virtual void ResetAppIcon()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAppSignonPolicy")]
        public virtual void ResetAppSignonPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAppsNetworkPerimeters")]
        public virtual void ResetAppsNetworkPerimeters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAppThumbnail")]
        public virtual void ResetAppThumbnail()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAsOpcService")]
        public virtual void ResetAsOpcService()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAttributes")]
        public virtual void ResetAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAttributeSets")]
        public virtual void ResetAttributeSets()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAttrRenderingMetadata")]
        public virtual void ResetAttrRenderingMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAudience")]
        public virtual void ResetAudience()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAuthorization")]
        public virtual void ResetAuthorization()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBypassConsent")]
        public virtual void ResetBypassConsent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificates")]
        public virtual void ResetCertificates()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientIpChecking")]
        public virtual void ResetClientIpChecking()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientType")]
        public virtual void ResetClientType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContactEmailAddress")]
        public virtual void ResetContactEmailAddress()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDelegatedServiceNames")]
        public virtual void ResetDelegatedServiceNames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisableKmsiTokenAuthentication")]
        public virtual void ResetDisableKmsiTokenAuthentication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetErrorPageUrl")]
        public virtual void ResetErrorPageUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForceDelete")]
        public virtual void ResetForceDelete()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHomePageUrl")]
        public virtual void ResetHomePageUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIcon")]
        public virtual void ResetIcon()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentityProviders")]
        public virtual void ResetIdentityProviders()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdpPolicy")]
        public virtual void ResetIdpPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdTokenEncAlgo")]
        public virtual void ResetIdTokenEncAlgo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsAliasApp")]
        public virtual void ResetIsAliasApp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsEnterpriseApp")]
        public virtual void ResetIsEnterpriseApp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsFormFill")]
        public virtual void ResetIsFormFill()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsKerberosRealm")]
        public virtual void ResetIsKerberosRealm()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsLoginTarget")]
        public virtual void ResetIsLoginTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsMobileTarget")]
        public virtual void ResetIsMobileTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsMulticloudServiceApp")]
        public virtual void ResetIsMulticloudServiceApp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsOauthClient")]
        public virtual void ResetIsOauthClient()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsOauthResource")]
        public virtual void ResetIsOauthResource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsObligationCapable")]
        public virtual void ResetIsObligationCapable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsRadiusApp")]
        public virtual void ResetIsRadiusApp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsSamlServiceProvider")]
        public virtual void ResetIsSamlServiceProvider()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsUnmanagedApp")]
        public virtual void ResetIsUnmanagedApp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsWebTierPolicy")]
        public virtual void ResetIsWebTierPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLandingPageUrl")]
        public virtual void ResetLandingPageUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLinkingCallbackUrl")]
        public virtual void ResetLinkingCallbackUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoginMechanism")]
        public virtual void ResetLoginMechanism()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoginPageUrl")]
        public virtual void ResetLoginPageUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogoutPageUrl")]
        public virtual void ResetLogoutPageUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogoutUri")]
        public virtual void ResetLogoutUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOcid")]
        public virtual void ResetOcid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPostLogoutRedirectUris")]
        public virtual void ResetPostLogoutRedirectUris()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivacyPolicyUrl")]
        public virtual void ResetPrivacyPolicyUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProductLogoUrl")]
        public virtual void ResetProductLogoUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProductName")]
        public virtual void ResetProductName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtectableSecondaryAudiences")]
        public virtual void ResetProtectableSecondaryAudiences()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRadiusPolicy")]
        public virtual void ResetRadiusPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedirectUris")]
        public virtual void ResetRedirectUris()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRefreshTokenExpiry")]
        public virtual void ResetRefreshTokenExpiry()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetResourceTypeSchemaVersion")]
        public virtual void ResetResourceTypeSchemaVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSamlServiceProvider")]
        public virtual void ResetSamlServiceProvider()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScopes")]
        public virtual void ResetScopes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecondaryAudiences")]
        public virtual void ResetSecondaryAudiences()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceParams")]
        public virtual void ResetServiceParams()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceTypeUrn")]
        public virtual void ResetServiceTypeUrn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceTypeVersion")]
        public virtual void ResetServiceTypeVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetShowInMyApps")]
        public virtual void ResetShowInMyApps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSignonPolicy")]
        public virtual void ResetSignonPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTermsOfServiceUrl")]
        public virtual void ResetTermsOfServiceUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTermsOfUse")]
        public virtual void ResetTermsOfUse()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrustPolicies")]
        public virtual void ResetTrustPolicies()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrustScope")]
        public virtual void ResetTrustScope()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrnietfparamsscimschemasoracleidcsextensiondbcsApp")]
        public virtual void ResetUrnietfparamsscimschemasoracleidcsextensiondbcsApp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp")]
        public virtual void ResetUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrnietfparamsscimschemasoracleidcsextensionformFillAppApp")]
        public virtual void ResetUrnietfparamsscimschemasoracleidcsextensionformFillAppApp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate")]
        public virtual void ResetUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp")]
        public virtual void ResetUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrnietfparamsscimschemasoracleidcsextensionmanagedappApp")]
        public virtual void ResetUrnietfparamsscimschemasoracleidcsextensionmanagedappApp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp")]
        public virtual void ResetUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrnietfparamsscimschemasoracleidcsextensionOciTags")]
        public virtual void ResetUrnietfparamsscimschemasoracleidcsextensionOciTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrnietfparamsscimschemasoracleidcsextensionopcServiceApp")]
        public virtual void ResetUrnietfparamsscimschemasoracleidcsextensionopcServiceApp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrnietfparamsscimschemasoracleidcsextensionradiusAppApp")]
        public virtual void ResetUrnietfparamsscimschemasoracleidcsextensionradiusAppApp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrnietfparamsscimschemasoracleidcsextensionrequestableApp")]
        public virtual void ResetUrnietfparamsscimschemasoracleidcsextensionrequestableApp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp")]
        public virtual void ResetUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp")]
        public virtual void ResetUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp()
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
        = GetStaticProperty<string>(typeof(oci.IdentityDomainsApp.IdentityDomainsApp))!;

        [JsiiProperty(name: "accounts", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAccountsList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppAccountsList Accounts
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppAccountsList>()!;
        }

        [JsiiProperty(name: "adminRoles", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAdminRolesList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppAdminRolesList AdminRoles
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppAdminRolesList>()!;
        }

        [JsiiProperty(name: "aliasApps", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAliasAppsList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppAliasAppsList AliasApps
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppAliasAppsList>()!;
        }

        [JsiiProperty(name: "allowedScopes", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAllowedScopesList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppAllowedScopesList AllowedScopes
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppAllowedScopesList>()!;
        }

        [JsiiProperty(name: "allowedTags", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAllowedTagsList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppAllowedTagsList AllowedTags
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppAllowedTagsList>()!;
        }

        [JsiiProperty(name: "appSignonPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAppSignonPolicyOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppAppSignonPolicyOutputReference AppSignonPolicy
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppAppSignonPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "appsNetworkPerimeters", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAppsNetworkPerimetersList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppAppsNetworkPerimetersList AppsNetworkPerimeters
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppAppsNetworkPerimetersList>()!;
        }

        [JsiiProperty(name: "asOpcService", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAsOpcServiceOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppAsOpcServiceOutputReference AsOpcService
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppAsOpcServiceOutputReference>()!;
        }

        [JsiiProperty(name: "attrRenderingMetadata", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAttrRenderingMetadataList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppAttrRenderingMetadataList AttrRenderingMetadata
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppAttrRenderingMetadataList>()!;
        }

        [JsiiProperty(name: "basedOnTemplate", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppBasedOnTemplateOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppBasedOnTemplateOutputReference BasedOnTemplate
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppBasedOnTemplateOutputReference>()!;
        }

        [JsiiProperty(name: "callbackServiceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CallbackServiceUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificates", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppCertificatesList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppCertificatesList Certificates
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppCertificatesList>()!;
        }

        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientSecret
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudControlProperties", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppCloudControlPropertiesList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppCloudControlPropertiesList CloudControlProperties
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppCloudControlPropertiesList>()!;
        }

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deleteInProgress", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteInProgress
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "domainOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "editableAttributes", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppEditableAttributesList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppEditableAttributesList EditableAttributes
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppEditableAttributesList>()!;
        }

        [JsiiProperty(name: "grantedAppRoles", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppGrantedAppRolesList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppGrantedAppRolesList GrantedAppRoles
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppGrantedAppRolesList>()!;
        }

        [JsiiProperty(name: "grants", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppGrantsList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppGrantsList Grants
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppGrantsList>()!;
        }

        [JsiiProperty(name: "hashedClientSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HashedClientSecret
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppIdcsCreatedByList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppIdcsLastModifiedByList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppIdcsLastModifiedByList>()!;
        }

        [JsiiProperty(name: "idcsLastUpgradedInRelease", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsLastUpgradedInRelease
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsPreventedOperations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdcsPreventedOperations
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "identityProviders", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppIdentityProvidersList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppIdentityProvidersList IdentityProviders
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppIdentityProvidersList>()!;
        }

        [JsiiProperty(name: "idpPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppIdpPolicyOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppIdpPolicyOutputReference IdpPolicy
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppIdpPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "infrastructure", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Infrastructure
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isDatabaseService", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDatabaseService
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isManagedApp", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsManagedApp
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isOpcService", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsOpcService
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppMetaList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppMetaList Meta
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppMetaList>()!;
        }

        [JsiiProperty(name: "meterAsOpcService", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable MeterAsOpcService
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "migrated", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Migrated
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "protectableSecondaryAudiences", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppProtectableSecondaryAudiencesList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppProtectableSecondaryAudiencesList ProtectableSecondaryAudiences
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppProtectableSecondaryAudiencesList>()!;
        }

        [JsiiProperty(name: "radiusPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppRadiusPolicyOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppRadiusPolicyOutputReference RadiusPolicy
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppRadiusPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "readyToUpgrade", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ReadyToUpgrade
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "samlServiceProvider", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppSamlServiceProviderOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppSamlServiceProviderOutputReference SamlServiceProvider
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppSamlServiceProviderOutputReference>()!;
        }

        [JsiiProperty(name: "scopes", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppScopesList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppScopesList Scopes
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppScopesList>()!;
        }

        [JsiiProperty(name: "serviceParams", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppServiceParamsList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppServiceParamsList ServiceParams
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppServiceParamsList>()!;
        }

        [JsiiProperty(name: "signonPolicy", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppSignonPolicyOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppSignonPolicyOutputReference SignonPolicy
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppSignonPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppTagsList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppTagsList Tags
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "termsOfUse", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppTermsOfUseOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppTermsOfUseOutputReference TermsOfUse
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppTermsOfUseOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppTimeoutsOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "trustPolicies", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppTrustPoliciesList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppTrustPoliciesList TrustPolicies
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppTrustPoliciesList>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensiondbcsApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensiondbcsAppOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensiondbcsAppOutputReference UrnietfparamsscimschemasoracleidcsextensiondbcsApp
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensiondbcsAppOutputReference>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionenterpriseAppApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppOutputReference UrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppOutputReference>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionformFillAppApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppAppOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppAppOutputReference UrnietfparamsscimschemasoracleidcsextensionformFillAppApp
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppAppOutputReference>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplateOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplateOutputReference UrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplateOutputReference>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionkerberosRealmApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmAppOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmAppOutputReference UrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmAppOutputReference>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionmanagedappApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppOutputReference UrnietfparamsscimschemasoracleidcsextensionmanagedappApp
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappAppOutputReference>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppAppOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppAppOutputReference UrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppAppOutputReference>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionOciTags", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionOciTagsOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionOciTagsOutputReference UrnietfparamsscimschemasoracleidcsextensionOciTags
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionOciTagsOutputReference>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionopcServiceApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceAppOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceAppOutputReference UrnietfparamsscimschemasoracleidcsextensionopcServiceApp
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceAppOutputReference>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionradiusAppApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppAppOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppAppOutputReference UrnietfparamsscimschemasoracleidcsextensionradiusAppApp
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppAppOutputReference>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionrequestableApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableAppOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableAppOutputReference UrnietfparamsscimschemasoracleidcsextensionrequestableApp
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableAppOutputReference>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppOutputReference UrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppOutputReference>()!;
        }

        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyAppOutputReference\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyAppOutputReference UrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyAppOutputReference>()!;
        }

        [JsiiProperty(name: "userRoles", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUserRolesList\"}")]
        public virtual oci.IdentityDomainsApp.IdentityDomainsAppUserRolesList UserRoles
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IdentityDomainsAppUserRolesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessTokenExpiryInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AccessTokenExpiryInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "activeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ActiveInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "aliasAppsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAliasApps\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AliasAppsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowAccessControlInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AllowAccessControlInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedGrantsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AllowedGrantsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedOperationsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AllowedOperationsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedScopesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAllowedScopes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AllowedScopesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedTagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAllowedTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AllowedTagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowOfflineInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AllowOfflineInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allUrlSchemesAllowedInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AllUrlSchemesAllowedInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "appIconInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AppIconInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "appSignonPolicyInput", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAppSignonPolicy\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppAppSignonPolicy? AppSignonPolicyInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppAppSignonPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "appsNetworkPerimetersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAppsNetworkPerimeters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AppsNetworkPerimetersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "appThumbnailInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AppThumbnailInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "asOpcServiceInput", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAsOpcService\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppAsOpcService? AsOpcServiceInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppAsOpcService?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributeSetsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AttributeSetsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AttributesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "attrRenderingMetadataInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppAttrRenderingMetadata\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AttrRenderingMetadataInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "audienceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AudienceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthorizationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "basedOnTemplateInput", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppBasedOnTemplate\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppBasedOnTemplate? BasedOnTemplateInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppBasedOnTemplate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bypassConsentInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? BypassConsentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificatesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppCertificates\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CertificatesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientIpCheckingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientIpCheckingInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "contactEmailAddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContactEmailAddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "delegatedServiceNamesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DelegatedServiceNamesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "disableKmsiTokenAuthenticationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DisableKmsiTokenAuthenticationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "errorPageUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ErrorPageUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceDeleteInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ForceDeleteInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "homePageUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HomePageUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iconInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IconInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idcsEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdcsEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityProvidersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppIdentityProviders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IdentityProvidersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idpPolicyInput", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppIdpPolicy\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppIdpPolicy? IdpPolicyInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppIdpPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idTokenEncAlgoInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdTokenEncAlgoInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isAliasAppInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsAliasAppInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isEnterpriseAppInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsEnterpriseAppInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isFormFillInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsFormFillInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isKerberosRealmInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsKerberosRealmInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isLoginTargetInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsLoginTargetInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isMobileTargetInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsMobileTargetInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isMulticloudServiceAppInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsMulticloudServiceAppInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isOauthClientInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsOauthClientInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isOauthResourceInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsOauthResourceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isObligationCapableInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsObligationCapableInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isRadiusAppInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsRadiusAppInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isSamlServiceProviderInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsSamlServiceProviderInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isUnmanagedAppInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsUnmanagedAppInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isWebTierPolicyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsWebTierPolicyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "landingPageUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LandingPageUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "linkingCallbackUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LinkingCallbackUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loginMechanismInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LoginMechanismInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loginPageUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LoginPageUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logoutPageUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogoutPageUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logoutUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogoutUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ocidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OcidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "postLogoutRedirectUrisInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PostLogoutRedirectUrisInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privacyPolicyUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivacyPolicyUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "productLogoUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProductLogoUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "productNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProductNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protectableSecondaryAudiencesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppProtectableSecondaryAudiences\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ProtectableSecondaryAudiencesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "radiusPolicyInput", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppRadiusPolicy\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppRadiusPolicy? RadiusPolicyInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppRadiusPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redirectUrisInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? RedirectUrisInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "refreshTokenExpiryInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RefreshTokenExpiryInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTypeSchemaVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceTypeSchemaVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "samlServiceProviderInput", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppSamlServiceProvider\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppSamlServiceProvider? SamlServiceProviderInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppSamlServiceProvider?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemasInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SchemasInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scopesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppScopes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ScopesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondaryAudiencesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecondaryAudiencesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceParamsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppServiceParams\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ServiceParamsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceTypeUrnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceTypeUrnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceTypeVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceTypeVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "showInMyAppsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ShowInMyAppsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "signonPolicyInput", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppSignonPolicy\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppSignonPolicy? SignonPolicyInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppSignonPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppTags\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "termsOfServiceUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TermsOfServiceUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "termsOfUseInput", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppTermsOfUse\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppTermsOfUse? TermsOfUseInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppTermsOfUse?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trustPoliciesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppTrustPolicies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TrustPoliciesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trustScopeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TrustScopeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensiondbcsAppInput", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensiondbcsApp\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensiondbcsApp? UrnietfparamsscimschemasoracleidcsextensiondbcsAppInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensiondbcsApp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionenterpriseAppAppInput", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp? UrnietfparamsscimschemasoracleidcsextensionenterpriseAppAppInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionenterpriseAppApp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionformFillAppAppInput", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppApp\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppApp? UrnietfparamsscimschemasoracleidcsextensionformFillAppAppInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppApp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplateInput", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate? UrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplateInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionkerberosRealmAppInput", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp? UrnietfparamsscimschemasoracleidcsextensionkerberosRealmAppInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionmanagedappAppInput", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappApp\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappApp? UrnietfparamsscimschemasoracleidcsextensionmanagedappAppInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmanagedappApp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppAppInput", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp? UrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppAppInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionmulticloudServiceAppApp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionOciTagsInput", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionOciTags\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionOciTags? UrnietfparamsscimschemasoracleidcsextensionOciTagsInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionOciTags?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionopcServiceAppInput", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceApp\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceApp? UrnietfparamsscimschemasoracleidcsextensionopcServiceAppInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionopcServiceApp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionradiusAppAppInput", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp? UrnietfparamsscimschemasoracleidcsextensionradiusAppAppInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionrequestableAppInput", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableApp\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableApp? UrnietfparamsscimschemasoracleidcsextensionrequestableAppInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionrequestableApp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppInput", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp? UrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "urnietfparamsscimschemasoracleidcsextensionwebTierPolicyAppInput", typeJson: "{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp\"}", isOptional: true)]
        public virtual oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp? UrnietfparamsscimschemasoracleidcsextensionwebTierPolicyAppInput
        {
            get => GetInstanceProperty<oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionwebTierPolicyApp?>();
        }

        [JsiiProperty(name: "accessTokenExpiry", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AccessTokenExpiry
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

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

        [JsiiProperty(name: "allowAccessControl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AllowAccessControl
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

        [JsiiProperty(name: "allowedGrants", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedGrants
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "allowedOperations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedOperations
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "allowOffline", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AllowOffline
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

        [JsiiProperty(name: "allUrlSchemesAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object AllUrlSchemesAllowed
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

        [JsiiProperty(name: "appIcon", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppIcon
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "appThumbnail", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppThumbnail
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Attributes
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AttributeSets
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Audience
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Authorization
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bypassConsent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object BypassConsent
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

        [JsiiProperty(name: "clientIpChecking", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientIpChecking
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "contactEmailAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContactEmailAddress
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "delegatedServiceNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DelegatedServiceNames
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "disableKmsiTokenAuthentication", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object DisableKmsiTokenAuthentication
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

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "errorPageUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorPageUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forceDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ForceDelete
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

        [JsiiProperty(name: "homePageUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HomePageUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "icon", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Icon
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "idTokenEncAlgo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdTokenEncAlgo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isAliasApp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsAliasApp
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

        [JsiiProperty(name: "isEnterpriseApp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsEnterpriseApp
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

        [JsiiProperty(name: "isFormFill", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsFormFill
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

        [JsiiProperty(name: "isKerberosRealm", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsKerberosRealm
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

        [JsiiProperty(name: "isLoginTarget", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsLoginTarget
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

        [JsiiProperty(name: "isMobileTarget", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsMobileTarget
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

        [JsiiProperty(name: "isMulticloudServiceApp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsMulticloudServiceApp
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

        [JsiiProperty(name: "isOauthClient", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsOauthClient
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

        [JsiiProperty(name: "isOauthResource", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsOauthResource
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

        [JsiiProperty(name: "isObligationCapable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsObligationCapable
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

        [JsiiProperty(name: "isRadiusApp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsRadiusApp
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

        [JsiiProperty(name: "isSamlServiceProvider", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsSamlServiceProvider
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

        [JsiiProperty(name: "isUnmanagedApp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsUnmanagedApp
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

        [JsiiProperty(name: "isWebTierPolicy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsWebTierPolicy
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

        [JsiiProperty(name: "landingPageUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LandingPageUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "linkingCallbackUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LinkingCallbackUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loginMechanism", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoginMechanism
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loginPageUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoginPageUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logoutPageUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoutPageUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logoutUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoutUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "postLogoutRedirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PostLogoutRedirectUris
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privacyPolicyUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivacyPolicyUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "productLogoUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductLogoUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "productName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "redirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RedirectUris
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "refreshTokenExpiry", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RefreshTokenExpiry
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeSchemaVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secondaryAudiences", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecondaryAudiences
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceTypeUrn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceTypeUrn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceTypeVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceTypeVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "showInMyApps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object ShowInMyApps
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

        [JsiiProperty(name: "termsOfServiceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TermsOfServiceUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trustScope", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrustScope
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}

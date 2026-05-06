using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementPlatformConfiguration
{
    [JsiiClass(nativeType: typeof(oci.FleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsOutputReference), fullyQualifiedName: "oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FleetAppsManagementPlatformConfigurationConfigCategoryDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FleetAppsManagementPlatformConfigurationConfigCategoryDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetAppsManagementPlatformConfigurationConfigCategoryDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FleetAppsManagementPlatformConfigurationConfigCategoryDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCompatibleProducts", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsCompatibleProducts\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCompatibleProducts(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsCompatibleProducts[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsCompatibleProducts).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsCompatibleProducts).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCredentials", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsCredentials\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCredentials(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsCredentials[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsCredentials).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsCredentials).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPatchTypes", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsPatchTypes\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPatchTypes(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsPatchTypes[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsPatchTypes).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsPatchTypes).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProducts", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsProducts\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutProducts(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsProducts[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsProducts).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsProducts).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSubCategoryDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsSubCategoryDetails\"}}]")]
        public virtual void PutSubCategoryDetails(oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsSubCategoryDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsSubCategoryDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCompatibleProducts")]
        public virtual void ResetCompatibleProducts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetComponents")]
        public virtual void ResetComponents()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCredentials")]
        public virtual void ResetCredentials()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceId")]
        public virtual void ResetInstanceId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceName")]
        public virtual void ResetInstanceName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPatchTypes")]
        public virtual void ResetPatchTypes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProducts")]
        public virtual void ResetProducts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubCategoryDetails")]
        public virtual void ResetSubCategoryDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersions")]
        public virtual void ResetVersions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "compatibleProducts", typeJson: "{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsCompatibleProductsList\"}")]
        public virtual oci.FleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsCompatibleProductsList CompatibleProducts
        {
            get => GetInstanceProperty<oci.FleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsCompatibleProductsList>()!;
        }

        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsCredentialsList\"}")]
        public virtual oci.FleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsCredentialsList Credentials
        {
            get => GetInstanceProperty<oci.FleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsCredentialsList>()!;
        }

        [JsiiProperty(name: "patchTypes", typeJson: "{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsPatchTypesList\"}")]
        public virtual oci.FleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsPatchTypesList PatchTypes
        {
            get => GetInstanceProperty<oci.FleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsPatchTypesList>()!;
        }

        [JsiiProperty(name: "products", typeJson: "{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsProductsList\"}")]
        public virtual oci.FleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsProductsList Products
        {
            get => GetInstanceProperty<oci.FleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsProductsList>()!;
        }

        [JsiiProperty(name: "subCategoryDetails", typeJson: "{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsSubCategoryDetailsOutputReference\"}")]
        public virtual oci.FleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsSubCategoryDetailsOutputReference SubCategoryDetails
        {
            get => GetInstanceProperty<oci.FleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsSubCategoryDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compatibleProductsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsCompatibleProducts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CompatibleProductsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "componentsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ComponentsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configCategoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigCategoryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsCredentials\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CredentialsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "patchTypesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsPatchTypes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PatchTypesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "productsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsProducts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ProductsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subCategoryDetailsInput", typeJson: "{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetailsSubCategoryDetails\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsSubCategoryDetails? SubCategoryDetailsInput
        {
            get => GetInstanceProperty<oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetailsSubCategoryDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? VersionsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "components", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Components
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "configCategory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigCategory
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "versions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Versions
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.fleetAppsManagementPlatformConfiguration.FleetAppsManagementPlatformConfigurationConfigCategoryDetails\"}", isOptional: true)]
        public virtual oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetails? InternalValue
        {
            get => GetInstanceProperty<oci.FleetAppsManagementPlatformConfiguration.IFleetAppsManagementPlatformConfigurationConfigCategoryDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}

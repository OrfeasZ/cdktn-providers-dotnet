using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager
{
    [JsiiClass(nativeType: typeof(azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatOutputReference), fullyQualifiedName: "azurerm.paloAltoNextGenerationFirewallVirtualHubStrataCloudManager.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBackendConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualHubStrataCloudManager.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatBackendConfig\"}}]")]
        public virtual void PutBackendConfig(azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatBackendConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatBackendConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFrontendConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualHubStrataCloudManager.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatFrontendConfig\"}}]")]
        public virtual void PutFrontendConfig(azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatFrontendConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatFrontendConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBackendConfig")]
        public virtual void ResetBackendConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFrontendConfig")]
        public virtual void ResetFrontendConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "backendConfig", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualHubStrataCloudManager.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatBackendConfigOutputReference\"}")]
        public virtual azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatBackendConfigOutputReference BackendConfig
        {
            get => GetInstanceProperty<azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatBackendConfigOutputReference>()!;
        }

        [JsiiProperty(name: "frontendConfig", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualHubStrataCloudManager.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatFrontendConfigOutputReference\"}")]
        public virtual azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatFrontendConfigOutputReference FrontendConfig
        {
            get => GetInstanceProperty<azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatFrontendConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "backendConfigInput", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualHubStrataCloudManager.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatBackendConfig\"}", isOptional: true)]
        public virtual azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatBackendConfig? BackendConfigInput
        {
            get => GetInstanceProperty<azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatBackendConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "frontendConfigInput", typeJson: "{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualHubStrataCloudManager.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatFrontendConfig\"}", isOptional: true)]
        public virtual azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatFrontendConfig? FrontendConfigInput
        {
            get => GetInstanceProperty<azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNatFrontendConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNat" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azurerm.paloAltoNextGenerationFirewallVirtualHubStrataCloudManager.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNat\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNat cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.PaloAltoNextGenerationFirewallVirtualHubStrataCloudManager.IPaloAltoNextGenerationFirewallVirtualHubStrataCloudManagerDestinationNat).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}

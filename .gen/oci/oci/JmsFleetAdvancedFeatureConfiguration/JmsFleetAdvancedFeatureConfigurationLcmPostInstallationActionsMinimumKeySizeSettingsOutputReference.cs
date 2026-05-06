using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsFleetAdvancedFeatureConfiguration
{
    [JsiiClass(nativeType: typeof(oci.JmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsOutputReference), fullyQualifiedName: "oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCertpath", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsCertpath\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCertpath(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsCertpath[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsCertpath).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsCertpath).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJar", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsJar\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutJar(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsJar[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsJar).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsJar).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTls", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsTls\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTls(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsTls[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsTls).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsTls).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCertpath")]
        public virtual void ResetCertpath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetJar")]
        public virtual void ResetJar()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTls")]
        public virtual void ResetTls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "certpath", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsCertpathList\"}")]
        public virtual oci.JmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsCertpathList Certpath
        {
            get => GetInstanceProperty<oci.JmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsCertpathList>()!;
        }

        [JsiiProperty(name: "jar", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsJarList\"}")]
        public virtual oci.JmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsJarList Jar
        {
            get => GetInstanceProperty<oci.JmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsJarList>()!;
        }

        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsTlsList\"}")]
        public virtual oci.JmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsTlsList Tls
        {
            get => GetInstanceProperty<oci.JmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsTlsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certpathInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsCertpath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CertpathInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jarInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsJar\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? JarInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettingsTls\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TlsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.jmsFleetAdvancedFeatureConfiguration.JmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettings\"}", isOptional: true)]
        public virtual oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettings? InternalValue
        {
            get => GetInstanceProperty<oci.JmsFleetAdvancedFeatureConfiguration.IJmsFleetAdvancedFeatureConfigurationLcmPostInstallationActionsMinimumKeySizeSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}

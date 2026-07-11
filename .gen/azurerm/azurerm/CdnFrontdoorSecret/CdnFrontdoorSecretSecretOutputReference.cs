using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorSecret
{
    [JsiiClass(nativeType: typeof(azurerm.CdnFrontdoorSecret.CdnFrontdoorSecretSecretOutputReference), fullyQualifiedName: "azurerm.cdnFrontdoorSecret.CdnFrontdoorSecretSecretOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CdnFrontdoorSecretSecretOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CdnFrontdoorSecretSecretOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CdnFrontdoorSecretSecretOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CdnFrontdoorSecretSecretOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorSecret.ICdnFrontdoorSecretSecretCustomerCertificate" />)[]</param>
        [JsiiMethod(name: "putCustomerCertificate", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorSecret.CdnFrontdoorSecretSecretCustomerCertificate\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCustomerCertificate(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.CdnFrontdoorSecret.ICdnFrontdoorSecretSecretCustomerCertificate[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorSecret.ICdnFrontdoorSecretSecretCustomerCertificate).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.CdnFrontdoorSecret.ICdnFrontdoorSecretSecretCustomerCertificate).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiProperty(name: "customerCertificate", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorSecret.CdnFrontdoorSecretSecretCustomerCertificateList\"}")]
        public virtual azurerm.CdnFrontdoorSecret.CdnFrontdoorSecretSecretCustomerCertificateList CustomerCertificate
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorSecret.CdnFrontdoorSecretSecretCustomerCertificateList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.CdnFrontdoorSecret.ICdnFrontdoorSecretSecretCustomerCertificate" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customerCertificateInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cdnFrontdoorSecret.CdnFrontdoorSecretSecretCustomerCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CustomerCertificateInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.cdnFrontdoorSecret.CdnFrontdoorSecretSecret\"}", isOptional: true)]
        public virtual azurerm.CdnFrontdoorSecret.ICdnFrontdoorSecretSecret? InternalValue
        {
            get => GetInstanceProperty<azurerm.CdnFrontdoorSecret.ICdnFrontdoorSecretSecret?>();
            set => SetInstanceProperty(value);
        }
    }
}

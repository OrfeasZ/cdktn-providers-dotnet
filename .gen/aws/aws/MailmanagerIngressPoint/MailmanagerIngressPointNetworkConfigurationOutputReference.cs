using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerIngressPoint
{
    [JsiiClass(nativeType: typeof(aws.MailmanagerIngressPoint.MailmanagerIngressPointNetworkConfigurationOutputReference), fullyQualifiedName: "aws.mailmanagerIngressPoint.MailmanagerIngressPointNetworkConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class MailmanagerIngressPointNetworkConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public MailmanagerIngressPointNetworkConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected MailmanagerIngressPointNetworkConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MailmanagerIngressPointNetworkConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerIngressPoint.IMailmanagerIngressPointNetworkConfigurationPrivateNetworkConfiguration" />)[]</param>
        [JsiiMethod(name: "putPrivateNetworkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerIngressPoint.MailmanagerIngressPointNetworkConfigurationPrivateNetworkConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPrivateNetworkConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.MailmanagerIngressPoint.IMailmanagerIngressPointNetworkConfigurationPrivateNetworkConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerIngressPoint.IMailmanagerIngressPointNetworkConfigurationPrivateNetworkConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerIngressPoint.IMailmanagerIngressPointNetworkConfigurationPrivateNetworkConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerIngressPoint.IMailmanagerIngressPointNetworkConfigurationPublicNetworkConfiguration" />)[]</param>
        [JsiiMethod(name: "putPublicNetworkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerIngressPoint.MailmanagerIngressPointNetworkConfigurationPublicNetworkConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPublicNetworkConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case aws.MailmanagerIngressPoint.IMailmanagerIngressPointNetworkConfigurationPublicNetworkConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerIngressPoint.IMailmanagerIngressPointNetworkConfigurationPublicNetworkConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerIngressPoint.IMailmanagerIngressPointNetworkConfigurationPublicNetworkConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPrivateNetworkConfiguration")]
        public virtual void ResetPrivateNetworkConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicNetworkConfiguration")]
        public virtual void ResetPublicNetworkConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "privateNetworkConfiguration", typeJson: "{\"fqn\":\"aws.mailmanagerIngressPoint.MailmanagerIngressPointNetworkConfigurationPrivateNetworkConfigurationList\"}")]
        public virtual aws.MailmanagerIngressPoint.MailmanagerIngressPointNetworkConfigurationPrivateNetworkConfigurationList PrivateNetworkConfiguration
        {
            get => GetInstanceProperty<aws.MailmanagerIngressPoint.MailmanagerIngressPointNetworkConfigurationPrivateNetworkConfigurationList>()!;
        }

        [JsiiProperty(name: "publicNetworkConfiguration", typeJson: "{\"fqn\":\"aws.mailmanagerIngressPoint.MailmanagerIngressPointNetworkConfigurationPublicNetworkConfigurationList\"}")]
        public virtual aws.MailmanagerIngressPoint.MailmanagerIngressPointNetworkConfigurationPublicNetworkConfigurationList PublicNetworkConfiguration
        {
            get => GetInstanceProperty<aws.MailmanagerIngressPoint.MailmanagerIngressPointNetworkConfigurationPublicNetworkConfigurationList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerIngressPoint.IMailmanagerIngressPointNetworkConfigurationPrivateNetworkConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "privateNetworkConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerIngressPoint.MailmanagerIngressPointNetworkConfigurationPrivateNetworkConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PrivateNetworkConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerIngressPoint.IMailmanagerIngressPointNetworkConfigurationPublicNetworkConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "publicNetworkConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerIngressPoint.MailmanagerIngressPointNetworkConfigurationPublicNetworkConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PublicNetworkConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="aws.MailmanagerIngressPoint.IMailmanagerIngressPointNetworkConfiguration" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.mailmanagerIngressPoint.MailmanagerIngressPointNetworkConfiguration\"}]}}", isOptional: true)]
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
                        case aws.MailmanagerIngressPoint.IMailmanagerIngressPointNetworkConfiguration cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.MailmanagerIngressPoint.IMailmanagerIngressPointNetworkConfiguration).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}

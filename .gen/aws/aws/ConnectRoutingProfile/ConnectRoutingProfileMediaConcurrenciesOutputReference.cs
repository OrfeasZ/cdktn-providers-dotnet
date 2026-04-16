using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectRoutingProfile
{
    [JsiiClass(nativeType: typeof(aws.ConnectRoutingProfile.ConnectRoutingProfileMediaConcurrenciesOutputReference), fullyQualifiedName: "aws.connectRoutingProfile.ConnectRoutingProfileMediaConcurrenciesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ConnectRoutingProfileMediaConcurrenciesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public ConnectRoutingProfileMediaConcurrenciesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected ConnectRoutingProfileMediaConcurrenciesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConnectRoutingProfileMediaConcurrenciesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCrossChannelBehavior", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.connectRoutingProfile.ConnectRoutingProfileMediaConcurrenciesCrossChannelBehavior\"}}]")]
        public virtual void PutCrossChannelBehavior(aws.ConnectRoutingProfile.IConnectRoutingProfileMediaConcurrenciesCrossChannelBehavior @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ConnectRoutingProfile.IConnectRoutingProfileMediaConcurrenciesCrossChannelBehavior)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCrossChannelBehavior")]
        public virtual void ResetCrossChannelBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "crossChannelBehavior", typeJson: "{\"fqn\":\"aws.connectRoutingProfile.ConnectRoutingProfileMediaConcurrenciesCrossChannelBehaviorOutputReference\"}")]
        public virtual aws.ConnectRoutingProfile.ConnectRoutingProfileMediaConcurrenciesCrossChannelBehaviorOutputReference CrossChannelBehavior
        {
            get => GetInstanceProperty<aws.ConnectRoutingProfile.ConnectRoutingProfileMediaConcurrenciesCrossChannelBehaviorOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "channelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ChannelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "concurrencyInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ConcurrencyInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "crossChannelBehaviorInput", typeJson: "{\"fqn\":\"aws.connectRoutingProfile.ConnectRoutingProfileMediaConcurrenciesCrossChannelBehavior\"}", isOptional: true)]
        public virtual aws.ConnectRoutingProfile.IConnectRoutingProfileMediaConcurrenciesCrossChannelBehavior? CrossChannelBehaviorInput
        {
            get => GetInstanceProperty<aws.ConnectRoutingProfile.IConnectRoutingProfileMediaConcurrenciesCrossChannelBehavior?>();
        }

        [JsiiProperty(name: "channel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Channel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "concurrency", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Concurrency
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"aws.connectRoutingProfile.ConnectRoutingProfileMediaConcurrencies\"}]}}", isOptional: true)]
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
                        case aws.ConnectRoutingProfile.IConnectRoutingProfileMediaConcurrencies cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.ConnectRoutingProfile.IConnectRoutingProfileMediaConcurrencies).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}

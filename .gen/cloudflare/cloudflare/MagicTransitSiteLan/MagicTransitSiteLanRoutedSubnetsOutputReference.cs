using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.MagicTransitSiteLan
{
    [JsiiClass(nativeType: typeof(cloudflare.MagicTransitSiteLan.MagicTransitSiteLanRoutedSubnetsOutputReference), fullyQualifiedName: "cloudflare.magicTransitSiteLan.MagicTransitSiteLanRoutedSubnetsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class MagicTransitSiteLanRoutedSubnetsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public MagicTransitSiteLanRoutedSubnetsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected MagicTransitSiteLanRoutedSubnetsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MagicTransitSiteLanRoutedSubnetsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNat", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.magicTransitSiteLan.MagicTransitSiteLanRoutedSubnetsNat\"}}]")]
        public virtual void PutNat(cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanRoutedSubnetsNat @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanRoutedSubnetsNat)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetNat")]
        public virtual void ResetNat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "nat", typeJson: "{\"fqn\":\"cloudflare.magicTransitSiteLan.MagicTransitSiteLanRoutedSubnetsNatOutputReference\"}")]
        public virtual cloudflare.MagicTransitSiteLan.MagicTransitSiteLanRoutedSubnetsNatOutputReference Nat
        {
            get => GetInstanceProperty<cloudflare.MagicTransitSiteLan.MagicTransitSiteLanRoutedSubnetsNatOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "natInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.magicTransitSiteLan.MagicTransitSiteLanRoutedSubnetsNat\"}]}}", isOptional: true)]
        public virtual object? NatInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nextHopInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NextHopInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "nextHop", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextHop
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Prefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.magicTransitSiteLan.MagicTransitSiteLanRoutedSubnets\"}]}}", isOptional: true)]
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
                        case cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanRoutedSubnets cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(cloudflare.MagicTransitSiteLan.IMagicTransitSiteLanRoutedSubnets).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}

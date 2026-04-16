using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiClass(nativeType: typeof(digitalocean.App.AppSpecIngressRuleOutputReference), fullyQualifiedName: "digitalocean.app.AppSpecIngressRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppSpecIngressRuleOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AppSpecIngressRuleOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AppSpecIngressRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppSpecIngressRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putComponent", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecIngressRuleComponent\"}}]")]
        public virtual void PutComponent(digitalocean.App.IAppSpecIngressRuleComponent @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecIngressRuleComponent)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCors", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecIngressRuleCors\"}}]")]
        public virtual void PutCors(digitalocean.App.IAppSpecIngressRuleCors @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecIngressRuleCors)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMatch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecIngressRuleMatch\"}}]")]
        public virtual void PutMatch(digitalocean.App.IAppSpecIngressRuleMatch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecIngressRuleMatch)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRedirect", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecIngressRuleRedirect\"}}]")]
        public virtual void PutRedirect(digitalocean.App.IAppSpecIngressRuleRedirect @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecIngressRuleRedirect)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetComponent")]
        public virtual void ResetComponent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCors")]
        public virtual void ResetCors()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMatch")]
        public virtual void ResetMatch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedirect")]
        public virtual void ResetRedirect()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "component", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleComponentOutputReference\"}")]
        public virtual digitalocean.App.AppSpecIngressRuleComponentOutputReference Component
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecIngressRuleComponentOutputReference>()!;
        }

        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleCorsOutputReference\"}")]
        public virtual digitalocean.App.AppSpecIngressRuleCorsOutputReference Cors
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecIngressRuleCorsOutputReference>()!;
        }

        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleMatchOutputReference\"}")]
        public virtual digitalocean.App.AppSpecIngressRuleMatchOutputReference Match
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecIngressRuleMatchOutputReference>()!;
        }

        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleRedirectOutputReference\"}")]
        public virtual digitalocean.App.AppSpecIngressRuleRedirectOutputReference Redirect
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecIngressRuleRedirectOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "componentInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleComponent\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecIngressRuleComponent? ComponentInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecIngressRuleComponent?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "corsInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleCors\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecIngressRuleCors? CorsInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecIngressRuleCors?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleMatch\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecIngressRuleMatch? MatchInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecIngressRuleMatch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redirectInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecIngressRuleRedirect\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecIngressRuleRedirect? RedirectInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecIngressRuleRedirect?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"digitalocean.app.AppSpecIngressRule\"}]}}", isOptional: true)]
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
                        case digitalocean.App.IAppSpecIngressRule cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecIngressRule).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}

.class Lcom/quattroplay/GraalEra/util/IabHelper$3$1;
.super Ljava/lang/Object;
.source "IabHelper.java"

# interfaces
.implements Ljava/lang/Runnable;


# annotations
.annotation system Ldalvik/annotation/EnclosingMethod;
    value = Lcom/quattroplay/GraalEra/util/IabHelper$3;->run()V
.end annotation

.annotation system Ldalvik/annotation/InnerClass;
    accessFlags = 0x0
    name = null
.end annotation


# instance fields
.field final synthetic this$1:Lcom/quattroplay/GraalEra/util/IabHelper$3;

.field final synthetic val$results:Ljava/util/List;


# direct methods
.method constructor <init>(Lcom/quattroplay/GraalEra/util/IabHelper$3;Ljava/util/List;)V
    .locals 0

    .prologue
    .line 965
    iput-object p1, p0, Lcom/quattroplay/GraalEra/util/IabHelper$3$1;->this$1:Lcom/quattroplay/GraalEra/util/IabHelper$3;

    iput-object p2, p0, Lcom/quattroplay/GraalEra/util/IabHelper$3$1;->val$results:Ljava/util/List;

    invoke-direct {p0}, Ljava/lang/Object;-><init>()V

    return-void
.end method


# virtual methods
.method public run()V
    .locals 4

    .prologue
    const/4 v3, 0x0

    .line 967
    iget-object v0, p0, Lcom/quattroplay/GraalEra/util/IabHelper$3$1;->this$1:Lcom/quattroplay/GraalEra/util/IabHelper$3;

    iget-object v2, v0, Lcom/quattroplay/GraalEra/util/IabHelper$3;->val$singleListener:Lcom/quattroplay/GraalEra/util/IabHelper$OnConsumeFinishedListener;

    iget-object v0, p0, Lcom/quattroplay/GraalEra/util/IabHelper$3$1;->this$1:Lcom/quattroplay/GraalEra/util/IabHelper$3;

    iget-object v0, v0, Lcom/quattroplay/GraalEra/util/IabHelper$3;->val$purchases:Ljava/util/List;

    invoke-interface {v0, v3}, Ljava/util/List;->get(I)Ljava/lang/Object;

    move-result-object v0

    check-cast v0, Lcom/quattroplay/GraalEra/util/Purchase;

    iget-object v1, p0, Lcom/quattroplay/GraalEra/util/IabHelper$3$1;->val$results:Ljava/util/List;

    invoke-interface {v1, v3}, Ljava/util/List;->get(I)Ljava/lang/Object;

    move-result-object v1

    check-cast v1, Lcom/quattroplay/GraalEra/util/IabResult;

    invoke-interface {v2, v0, v1}, Lcom/quattroplay/GraalEra/util/IabHelper$OnConsumeFinishedListener;->onConsumeFinished(Lcom/quattroplay/GraalEra/util/Purchase;Lcom/quattroplay/GraalEra/util/IabResult;)V

    .line 968
    return-void
.end method

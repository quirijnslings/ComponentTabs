﻿<script type="text/javascript">
    setTimeout(function () {
        var item = $display.getItem();
        var metaData = item.getMetadata();
        var metaSrcDiv = $(".metaSrc");
        metaSrcDiv.textContent = metaData;
    }, 2000);
</script>

<%@ Control Language="C#" AutoEventWireup="true" %>
<pre>
    <code class="metaSrc">
        metaSrc
    </code>
</pre>
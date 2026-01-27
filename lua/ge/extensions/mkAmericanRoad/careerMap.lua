return {
    onGetMaps = function()
        extensions.hook("returnCompatibleMap", {["mk_americanroad"] = "American Road"})
    end
}